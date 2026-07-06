using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmAIRecommendation : Form
    {
        private PharmacyDbContext db = new PharmacyDbContext();

        public frmAIRecommendation()
        {
            InitializeComponent();
        }

        private void frmAIRecommendation_Load(object sender, EventArgs e)
        {
            try
            {
                // Nạp danh sách Khách hàng
                cbCustomers.DisplayMember = "FullName";
                cbCustomers.ValueMember = "CustomerId";
                cbCustomers.DataSource = db.Customers.Select(c => new { c.CustomerId, FullName = c.FullName }).ToList();
                cbCustomers.Text = null;

                // Nạp danh sách Sản phẩm thuốc
                cbProducts.DisplayMember = "ProductName";
                cbProducts.ValueMember = "ProductId";
                cbProducts.DataSource = db.Products.Select(p => new { p.ProductId, ProductName = p.ProductName }).ToList();
                cbProducts.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu cho giao diện AI: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1. Lấy dữ liệu từ CSDL, trả về 2 tập: huấn luyện (training) và kiểm tra (test)
        public static (IDataView training, IDataView test) LoadData(MLContext mlContext)
        {
            using var db = new PharmacyDbContext();

            // Khắc phục 5 lỗi khi chuyển đổi code từ bài hướng dẫn phim sang quản lý thuốc:
            // - Lỗi 1 & 2: OrderDetail không có ProductId -> Phải Include(od => od.ImportDetail) và lấy od.ImportDetail.ProductId
            // - Lỗi 3 & 4: CustomerId trong Order là nullable (long?) -> Lọc od.Order.CustomerId.HasValue và ép kiểu an toàn
            // - Lỗi 5: Map đúng kiểu dữ liệu float cho CustomerId, ProductId và QuantityBought
            var list = db.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.ImportDetail)
                .Where(od => od.Order != null && od.Order.CustomerId.HasValue && od.ImportDetail != null)
                .Select(od => new MedicineRating
                {
                    CustomerId = (float)od.Order!.CustomerId!.Value,
                    ProductId = (float)od.ImportDetail.ProductId, // Lấy từ ImportDetail
                    QuantityBought = (float)od.Quantity
                })
                .ToList();

            if (list.Count == 0)
            {
                throw new Exception("Chưa có đủ dữ liệu lịch sử hóa đơn mua thuốc trong CSDL để huấn luyện AI!");
            }

            IDataView dataView = mlContext.Data.LoadFromEnumerable(list);

            // Chia theo tỉ lệ 20% dữ liệu kiểm tra, 80% dữ liệu huấn luyện
            DataOperationsCatalog.TrainTestData dataSplit = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2);
            return (dataSplit.TrainSet, dataSplit.TestSet);
        }

        // 2. Huấn luyện và xây dựng mô hình gợi ý thuốc bằng thuật toán MatrixFactorization
        public static ITransformer BuildAndTrainModel(MLContext mlContext, IDataView trainingDataView)
        {
            // Sử dụng đúng tên thuộc tính CustomerId và ProductId trong class MedicineRating
            IEstimator<ITransformer> estimator = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "customerIdEncoded", inputColumnName: nameof(MedicineRating.CustomerId))
                .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "productIdEncoded", inputColumnName: nameof(MedicineRating.ProductId)));

            // Thiết lập các thông số cho thuật toán MatrixFactorization, LabelColumnName là QuantityBought
            var options = new MatrixFactorizationTrainer.Options
            {
                MatrixColumnIndexColumnName = "customerIdEncoded",
                MatrixRowIndexColumnName = "productIdEncoded",
                LabelColumnName = nameof(MedicineRating.QuantityBought),
                NumberOfIterations = 20,
                ApproximationRank = 100
            };

            var trainerEstimator = estimator.Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));
            ITransformer model = trainerEstimator.Fit(trainingDataView);
            return model;
        }

        // 3. Đánh giá mô hình trên tập kiểm tra
        public static string EvaluateModel(MLContext mlContext, IDataView testDataView, ITransformer model)
        {
            var prediction = model.Transform(testDataView);
            var metrics = mlContext.Regression.Evaluate(prediction, labelColumnName: nameof(MedicineRating.QuantityBought), scoreColumnName: "Score");
            
            return $"✔ Đánh giá Mô hình AI thành công!\r\n\r\n" +
                   $"• Root Mean Squared Error (RMSE): {metrics.RootMeanSquaredError:F2}\r\n" +
                   $"• RSquared (R² - Độ chính xác): {metrics.RSquared:P2}\r\n\r\n" +
                   $"Mô hình đã học xong xu hướng mua của khách hàng và sẵn sàng tư vấn!";
        }

        // 4. Lưu mô hình thành file zip
        public static string SaveModel(MLContext mlContext, DataViewSchema schema, ITransformer model)
        {
            string modelPath = Path.Combine(Application.StartupPath, "MedicineRecommenderModel.zip");
            mlContext.Model.Save(model, schema, modelPath);
            return $"Lưu mô hình thành công tại:\r\n{modelPath}";
        }

        private void btTrain_Click(object sender, EventArgs e)
        {
            try
            {
                txtEvaluate.Text = "⏳ Đang đọc lịch sử hóa đơn từ CSDL và huấn luyện AI... Vui lòng đợi...";
                Application.DoEvents();

                MLContext mlContext = new MLContext();
                var (trainingData, testData) = LoadData(mlContext);

                ITransformer model = BuildAndTrainModel(mlContext, trainingData);
                string evalResult = EvaluateModel(mlContext, testData, model);
                string saveResult = SaveModel(mlContext, trainingData.Schema, model);

                txtEvaluate.Text = $"{evalResult}\r\n\r\n{saveResult}";
                MessageBox.Show("Huấn luyện mô hình AI gợi ý thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                txtEvaluate.Text = "❌ Lỗi huấn luyện: " + ex.Message;
                MessageBox.Show("Lỗi khi huấn luyện mô hình AI:\r\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPredict_Click(object sender, EventArgs e)
        {
            if (cbCustomers.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Khách hàng cần tư vấn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCustomers.Focus();
                return;
            }

            if (cbProducts.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm thuốc cần phân tích!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbProducts.Focus();
                return;
            }

            string modelPath = Path.Combine(Application.StartupPath, "MedicineRecommenderModel.zip");
            if (!File.Exists(modelPath))
            {
                MessageBox.Show("Chưa có mô hình AI! Vui lòng nhấn nút 'Huấn luyện & Xây dựng Mô hình' bên trái trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MLContext mlContext = new MLContext();
                ITransformer model = mlContext.Model.Load(modelPath, out var schema);
                var predictionEngine = mlContext.Model.CreatePredictionEngine<MedicineRating, MedicineRatingPrediction>(model);

                float customerId = Convert.ToSingle(cbCustomers.SelectedValue);
                float productId = Convert.ToSingle(cbProducts.SelectedValue);

                // Dự đoán điểm quan tâm của khách hàng với sản phẩm đã chọn
                var testInput = new MedicineRating { CustomerId = customerId, ProductId = productId };
                var prediction = predictionEngine.Predict(testInput);

                string customerName = cbCustomers.Text;
                string productName = cbProducts.Text;

                string resultText = $"🔍 KẾT QUẢ PHÂN TÍCH CHO KHÁCH HÀNG: {customerName.ToUpper()}\r\n";
                resultText += $"• Sản phẩm kiểm tra: {productName}\r\n";
                resultText += $"• Điểm dự đoán AI (Score): {prediction.Score:F2}\r\n\r\n";

                if (prediction.Score >= 1.5f)
                {
                    resultText += $"⭐ ĐÁNH GIÁ: Khách hàng CÓ XU HƯỚNG MUA thuốc này!\r\n";
                    resultText += $"=> Lời khuyên: Nên giới thiệu, tư vấn hoặc đưa vào đơn thuốc cho khách.\r\n\r\n";
                }
                else
                {
                    resultText += $"⚠️ ĐÁNH GIÁ: Khách hàng ÍT QUAN TÂM hoặc ít có nhu cầu với thuốc này.\r\n";
                    resultText += $"=> Lời khuyên: Có thể tư vấn dòng thuốc khác phù hợp hơn.\r\n\r\n";
                }

                // Gợi ý thêm top 3 thuốc có khả năng khách mua cao nhất
                resultText += "💡 TOP 3 THUỐC ĐỀ XUẤT PHÙ HỢP NHẤT CHO KHÁCH HÀNG NÀY:\r\n";
                var allProducts = db.Products.Where(p => p.Status).ToList();
                var recommendations = new List<(string Name, float Score)>();

                foreach (var p in allProducts)
                {
                    var pred = predictionEngine.Predict(new MedicineRating { CustomerId = customerId, ProductId = (float)p.ProductId });
                    recommendations.Add((p.ProductName, pred.Score));
                }

                var top3 = recommendations.OrderByDescending(r => r.Score).Take(3).ToList();
                int rank = 1;
                foreach (var item in top3)
                {
                    resultText += $"   {rank++}. {item.Name} (Điểm AI: {item.Score:F2})\r\n";
                }

                lblResult.Text = resultText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi dự đoán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
