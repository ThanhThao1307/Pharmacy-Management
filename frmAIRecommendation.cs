using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
                // Tải danh sách sản phẩm
                var prodList = new List<object>
                {
                    new { ProductId = 0L, ProductName = "-- Tất cả sản phẩm (Phân tích toàn bộ kho & xu hướng mua) --" }
                };
                prodList.AddRange(db.Products.Where(p => p.Status).Select(p => new { p.ProductId, ProductName = p.ProductName }).ToList());

                cbProducts.DisplayMember = "ProductName";
                cbProducts.ValueMember = "ProductId";
                cbProducts.DataSource = prodList;
                cbProducts.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu cho giao diện AI: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static (IDataView training, IDataView test) LoadData(MLContext mlContext)
        {
            using var db = new PharmacyDbContext();

            // Lấy lịch sử bán thuốc
            var rawList = db.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.ImportDetail)
                .Where(od => od.Order != null && od.ImportDetail != null && !od.Order.Status)
                .Select(od => new
                {
                    CustomerId = od.Order!.CustomerId ?? 1L,
                    ProductId = od.ImportDetail.ProductId,
                    Quantity = od.Quantity
                })
                .ToList();

            if (rawList.Count == 0)
            {
                throw new Exception("Chưa có đủ dữ liệu lịch sử hóa đơn mua thuốc trong CSDL để AI phân tích!");
            }

            // Tổng hợp số lượng bán
            var list = rawList
                .GroupBy(x => new { x.CustomerId, x.ProductId })
                .Select(g => new MedicineRating
                {
                    CustomerId = (float)g.Key.CustomerId,
                    ProductId = (float)g.Key.ProductId,
                    QuantityBought = (float)g.Sum(x => x.Quantity)
                })
                .ToList();

            IDataView dataView = mlContext.Data.LoadFromEnumerable(list);
            double testFraction = list.Count <= 5 ? 0.1 : 0.2;
            DataOperationsCatalog.TrainTestData dataSplit = mlContext.Data.TrainTestSplit(dataView, testFraction: testFraction);
            return (dataSplit.TrainSet, dataSplit.TestSet);
        }

        public static ITransformer BuildAndTrainModel(MLContext mlContext, IDataView trainingDataView)
        {
            IEstimator<ITransformer> estimator = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "customerIdEncoded", inputColumnName: nameof(MedicineRating.CustomerId))
                .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "productIdEncoded", inputColumnName: nameof(MedicineRating.ProductId)));

            var options = new MatrixFactorizationTrainer.Options
            {
                MatrixColumnIndexColumnName = "customerIdEncoded",
                MatrixRowIndexColumnName = "productIdEncoded",
                LabelColumnName = nameof(MedicineRating.QuantityBought),
                NumberOfIterations = 50,
                ApproximationRank = 16,
                Alpha = 0.01,
                Lambda = 0.025
            };

            var trainerEstimator = estimator.Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));
            return trainerEstimator.Fit(trainingDataView);
        }

        public static void SaveModel(MLContext mlContext, DataViewSchema schema, ITransformer model)
        {
            string modelPath = Path.Combine(Application.StartupPath, "MedicineRecommenderModel.zip");
            mlContext.Model.Save(model, schema, modelPath);
        }

        private void EnsureModelReady()
        {
            string modelPath = Path.Combine(Application.StartupPath, "MedicineRecommenderModel.zip");
            if (File.Exists(modelPath)) return;

            MLContext mlContext = new MLContext();
            var (trainingData, _) = LoadData(mlContext);

            using var db = new PharmacyDbContext();
            var fullList = db.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.ImportDetail)
                .Where(od => od.Order != null && od.ImportDetail != null && !od.Order.Status)
                .GroupBy(x => new { CustomerId = x.Order!.CustomerId ?? 1L, x.ImportDetail!.ProductId })
                .Select(g => new MedicineRating
                {
                    CustomerId = (float)g.Key.CustomerId,
                    ProductId = (float)g.Key.ProductId,
                    QuantityBought = (float)g.Sum(x => x.Quantity)
                }).ToList();

            IDataView fullDataView = mlContext.Data.LoadFromEnumerable(fullList);
            ITransformer finalModel = BuildAndTrainModel(mlContext, fullDataView);
            SaveModel(mlContext, fullDataView.Schema, finalModel);
        }

        private void btPredict_Click(object sender, EventArgs e)
        {
            if (cbProducts.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm thuốc cần phân tích!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbProducts.Focus();
                return;
            }

            try
            {
                EnsureModelReady();
                string modelPath = Path.Combine(Application.StartupPath, "MedicineRecommenderModel.zip");
                if (!File.Exists(modelPath)) return;

                MLContext mlContext = new MLContext();
                ITransformer model = mlContext.Model.Load(modelPath, out var _);
                var predictionEngine = mlContext.Model.CreatePredictionEngine<MedicineRating, MedicineRatingPrediction>(model);

                long selectedProductId = Convert.ToInt64(cbProducts.SelectedValue);
                Product? selectedProduct = selectedProductId > 0 ? db.Products.Include(p => p.Category).Include(p => p.ImportDetails).FirstOrDefault(p => p.ProductId == selectedProductId) : null;

                // Lấy danh sách sản phẩm
                var allProducts = db.Products.Include(p => p.Category).Include(p => p.ImportDetails).Where(p => p.Status).ToList();
                
                // Thống kê số lượng bán
                var totalProdSoldMap = db.OrderDetails
                    .Where(od => od.ImportDetail != null && od.Order != null && !od.Order.Status)
                    .GroupBy(od => od.ImportDetail.ProductId)
                    .Select(g => new { ProductId = g.Key, Qty = g.Sum(x => x.Quantity) })
                    .ToDictionary(x => x.ProductId, x => x.Qty);

                var productAnalysis = new List<(Product Prod, float Score, int TotalSold, int CurrentStock, int PredictedDemand)>();
                foreach (var p in allProducts)
                {
                    var pred = predictionEngine.Predict(new MedicineRating { CustomerId = 1f, ProductId = (float)p.ProductId });
                    float sc = pred.Score;
                    int totalSold = totalProdSoldMap.ContainsKey(p.ProductId) ? totalProdSoldMap[p.ProductId] : 0;
                    int currentStock = p.TotalStock;

                    if (float.IsNaN(sc) || sc < 0)
                    {
                        sc = totalSold > 20 ? 3.5f : (totalSold > 5 ? 1.8f : (totalSold > 0 ? 0.9f : 0.4f));
                    }

                    // Tính số lượng dự đoán
                    int predictedDemand = totalSold > 0 ? Math.Max(15, (int)(totalSold * 1.35f + sc * 10f)) : Math.Max(20, (int)(sc * 18f));
                    productAnalysis.Add((p, sc, totalSold, currentStock, predictedDemand));
                }

                // Sắp xếp theo xu hướng và số lượng bán
                var topTrendingInStore = productAnalysis.OrderByDescending(x => x.TotalSold).ThenByDescending(x => x.Score).ToList();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("BÁO CÁO PHÂN TÍCH NHU CẦU TIÊU THỤ, ĐỀ XUẤT CHUẨN BỊ KHO & SUY ĐOÁN MÙA BỆNH");
                sb.AppendLine($"Thời gian phân tích: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                sb.AppendLine($"Chế độ phân tích: {(selectedProduct != null ? $"Phân tích chi tiết thuốc [{selectedProduct.ProductName}]" : "Phân tích tổng quan toàn bộ kho & thị trường")}");
                sb.AppendLine();

                // Phân tích và dự đoán nhu cầu
                sb.AppendLine("[I] PHÂN TÍCH SẢN PHẨM LỰA CHỌN & DỰ ĐOÁN NHU CẦU CHUẨN BỊ KHO:");
                if (selectedProduct != null)
                {
                    var itemInfo = productAnalysis.First(x => x.Prod.ProductId == selectedProduct.ProductId);
                    int totalSold = itemInfo.TotalSold;
                    int currentStock = itemInfo.CurrentStock;
                    int predictedDemand = itemInfo.PredictedDemand;
                    float sc = itemInfo.Score;

                    sb.AppendLine($"  Tên sản phẩm: {selectedProduct.ProductName} (Mã: {selectedProduct.ProductCode})");
                    sb.AppendLine($"  Danh mục thuốc: {selectedProduct.Category.CategoryName}");
                    sb.AppendLine($"  Đơn vị tính: {selectedProduct.Unit} (vỉ / hộp / viên / chai / lọ...)");
                    sb.AppendLine($"  Quy định kê đơn: {(selectedProduct.PrescriptionRequired ? "BẮT BUỘC CÓ TOA BÁC SĨ (Rx - Thuốc kê đơn)" : "THUỐC KHÔNG KÊ ĐƠN (OTC - Bán trực tiếp)")}");
                    sb.AppendLine();

                    sb.AppendLine("  DỮ LIỆU BÁN HÀNG & THÔNG TIN DÙNG ĐỂ DỰ ĐOÁN:");
                    sb.AppendLine($"  - Tổng số lượng đã xuất bán trong CSDL: {totalSold} {selectedProduct.Unit}");
                    sb.AppendLine($"  - Số lượng tồn kho thực tế hiện tại: {currentStock} {selectedProduct.Unit}");
                    sb.AppendLine($"  - Nhịp độ tiêu thụ và sức mua thị trường: {(sc >= 2.5f || totalSold >= 30 ? "ĐANG TIÊU THỤ RẤT MẠNH / ĐẮT HÀNG" : (sc >= 1.0f || totalSold >= 10 ? "TIÊU THỤ ỔN ĐỊNH - ĐỀU ĐẶN" : "GIAO DỊCH CHẬM / ÍT NHU CẦU"))}");
                    sb.AppendLine();

                    sb.AppendLine("  KẾT LUẬN & DỰ ĐOÁN:");
                    sb.AppendLine($"  - Dự đoán nhu cầu mua sắp tới: ~ {predictedDemand} {selectedProduct.Unit}");
                    sb.AppendLine($"  - So sánh kho vs Dự đoán nhu cầu: Tồn kho hiện tại ({currentStock} {selectedProduct.Unit}) so với Dự đoán sắp tới ({predictedDemand} {selectedProduct.Unit})");
                    sb.AppendLine();

                    sb.AppendLine("  KHUYẾN NGHỊ KẾ HOẠCH CHUẨN BỊ SỐ LƯỢNG KHO:");
                    if (currentStock < predictedDemand)
                    {
                        int deficit = predictedDemand - currentStock + 25; // Lượng cần nhập bù
                        sb.AppendLine("    CẢNH BÁO THIẾU HỤT KHO: Số lượng trong kho HIỆN TẠI KHÔNG ĐỦ để đáp ứng nhu cầu tăng cao sắp tới!");
                        sb.AppendLine($"    Kế hoạch chuẩn bị: Nhà thuốc cần lập phiếu nhập kho KHẨN CẤP bổ sung ngay ít nhất [{deficit} {selectedProduct.Unit}] để tránh nguy cơ cháy hàng trong giai đoạn tới.");
                    }
                    else if (currentStock < (int)(predictedDemand * 1.4f))
                    {
                        sb.AppendLine("    CẢNH BÁO MỨC TỒN AN TOÀN: Nguồn kho hiện tại đang vừa đủ đáp ứng nhưng đã sát ngưỡng dự đoán.");
                        sb.AppendLine($"    Kế hoạch chuẩn bị: Nên liên hệ nhà cung cấp để dự trù chuẩn bị nhập thêm ~ [{predictedDemand} {selectedProduct.Unit}] trong đợt nhập hàng tiếp theo.");
                    }
                    else
                    {
                        sb.AppendLine("    NGUỒN HÀNG ĐẢM BẢO: Số lượng trong kho HIỆN TẠI ĐANG DƯ DẢ và hoàn toàn đáp ứng tốt nhu cầu mua sắp tới.");
                        sb.AppendLine("    Kế hoạch chuẩn bị: Chưa cần nhập thêm lô mới. Tiếp tục duy trì bán, theo dõi nhịp độ tiêu thụ và kiểm tra hạn sử dụng định kỳ.");
                    }
                    sb.AppendLine();

                    sb.AppendLine("  KIỂM SOÁT TOA THUỐC GPP KHI XUẤT BÁN:");
                    if (selectedProduct.PrescriptionRequired)
                    {
                        sb.AppendLine("    Lưu ý GPP (Thuốc kê đơn Rx): Vì đây là thuốc kê đơn bắt buộc, khi nhu cầu mua tăng cao sắp tới, Dược sĩ phải tuân thủ");
                        sb.AppendLine("    chặt chẽ quy trình kiểm tra Toa chỉ định của Bác sĩ, lưu hình ảnh hồ sơ toa hợp lệ vào CSDL, tuyệt đối không bán tùy tiện.");
                    }
                    else
                    {
                        sb.AppendLine("    Lưu ý GPP (Thuốc OTC): Sản phẩm không bắt buộc kê đơn. Dược sĩ có thể tư vấn liều dùng, cách sử dụng an toàn");
                        sb.AppendLine("    và giải thích công dụng rõ ràng cho người bệnh trực tiếp tại quầy.");
                    }
                }
                else
                {
                    sb.AppendLine("  Bạn đang chọn [-- Tất cả sản phẩm --]. Hệ thống thực hiện phân tích toàn diện trên 100% mặt hàng trong kho để tra cứu các thuốc có nhu cầu cao nhất.");
                }
                sb.AppendLine();

                // Suy đoán mùa bệnh
                sb.AppendLine("[II] SUY ĐOÁN MÙA BỆNH TỪ DỮ LIỆU BÁN HÀNG THỰC TẾ TRÊN HỆ THỐNG:");
                sb.AppendLine(DiagnoseDiseaseSeason(topTrendingInStore));
                sb.AppendLine();

                // Top 5 thuốc mua nhiều nhất
                sb.AppendLine("[III] DANH SÁCH 5 LOẠI THUỐC ĐANG ĐƯỢC MUA NHIỀU NHẤT HIỆN NAY & ĐỀ XUẤT CHUẨN BỊ:");
                int rank = 1;
                foreach (var rec in topTrendingInStore.Take(5))
                {
                    string rxTag = rec.Prod.PrescriptionRequired ? "[Rx - Kê đơn]" : "[OTC - Không kê đơn]";
                    string statusTag = rec.CurrentStock < rec.PredictedDemand ? "Thiếu hụt -> Cần nhập bổ sung khẩn cấp" : "Kho đủ đáp ứng -> Tiếp tục theo dõi";

                    sb.AppendLine($"  {rank++}. {rec.Prod.ProductName} - {rxTag}");
                    sb.AppendLine($"     Danh mục: {rec.Prod.Category.CategoryName} | Đơn vị tính: {rec.Prod.Unit}");
                    sb.AppendLine($"     Đã bán thực tế: {rec.TotalSold} {rec.Prod.Unit} | Tồn kho HIỆN TẠI: {rec.CurrentStock} {rec.Prod.Unit} | Dự đoán sắp tới: ~ {rec.PredictedDemand} {rec.Prod.Unit}");
                    sb.AppendLine($"     Đánh giá kho: {statusTag}");
                }
                sb.AppendLine();
                sb.AppendLine("CHỈ ĐỊNH DƯỢC SĨ: Luôn theo dõi sát sao số liệu xuất bán, chuẩn bị nguồn hàng trước các đợt cao điểm");
                sb.AppendLine("mùa bệnh và đảm bảo tư vấn hướng dẫn sử dụng thuốc an toàn, hiệu quả cho người bệnh theo GPP.");

                txtResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phân tích dự đoán AI: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Suy đoán mùa bệnh từ xu hướng mua
        private string DiagnoseDiseaseSeason(List<(Product Prod, float Score, int TotalSold, int CurrentStock, int PredictedDemand)> trendingList)
        {
            if (trendingList.Count == 0)
                return "  Chưa có đủ dữ liệu bán hàng để kết luận xu hướng mùa bệnh.";

            int respScore = 0, digScore = 0, jointScore = 0, chronicScore = 0, tonicScore = 0;

            foreach (var item in trendingList.Take(10))
            {
                string name = (item.Prod.ProductName + " " + item.Prod.Category.CategoryName + " " + (item.Prod.Description ?? "")).ToLower();
                int weight = Math.Max(1, item.TotalSold) + (int)(item.Score * 2);

                if (name.Contains("cảm") || name.Contains("cúm") || name.Contains("ho") || name.Contains("sốt") || name.Contains("họng") || name.Contains("phế quản") || name.Contains("kháng sinh") || name.Contains("paracetamol") || name.Contains("siro") || name.Contains("histamin") || name.Contains("cetirizin") || name.Contains("loratadin") || name.Contains("hô hấp"))
                    respScore += weight * 2;
                if (name.Contains("tiêu hóa") || name.Contains("dạ dày") || name.Contains("tiêu chảy") || name.Contains("smecta") || name.Contains("berberin") || name.Contains("oresol") || name.Contains("men vi sinh") || name.Contains("omeprazol") || name.Contains("phosphalugel") || name.Contains("đường ruột"))
                    digScore += weight * 2;
                if (name.Contains("xương khớp") || name.Contains("đau nhức") || name.Contains("khớp") || name.Contains("gout") || name.Contains("diclofenac") || name.Contains("meloxicam") || name.Contains("glucosamin") || name.Contains("canxi") || name.Contains("salonpas"))
                    jointScore += weight * 2;
                if (name.Contains("huyết áp") || name.Contains("tim mạch") || name.Contains("tiểu đường") || name.Contains("amlodipin") || name.Contains("metformin") || name.Contains("losartan") || name.Contains("insulin") || name.Contains("mỡ máu"))
                    chronicScore += weight * 2;
                if (name.Contains("bổ") || name.Contains("vitamin") || name.Contains("hoạt huyết") || name.Contains("omega") || name.Contains("kẽm") || name.Contains("đề kháng") || name.Contains("dinh dưỡng"))
                    tonicScore += weight;
            }

            int maxScore = Math.Max(respScore, Math.Max(digScore, Math.Max(jointScore, Math.Max(chronicScore, tonicScore))));

            StringBuilder diag = new StringBuilder();
            if (maxScore == 0 || (respScore == 0 && digScore == 0 && jointScore == 0 && chronicScore == 0))
            {
                diag.AppendLine("  Kết luận cụ thể: Thị trường tiêu thụ thuốc đang ở mức ỔN ĐỊNH TỔNG QUAN, chưa xuất hiện bùng phát mùa bệnh dịch truyền nhiễm.");
                diag.AppendLine("  - Khuyến nghị Dược sĩ: Duy trì nguồn hàng đa dạng và tập trung vào các nhóm thuốc thiết yếu hàng ngày.");
            }
            else if (maxScore == respScore)
            {
                diag.AppendLine("  Kết luận cụ thể: Đang là GIAI ĐOẠN CAO ĐIỂM CÁC BỆNH ĐƯỜNG HÔ HẤP (Cảm cúm, Sốt, Ho, Viêm họng, Viêm mũi dị ứng).");
                diag.AppendLine("  - Ngữ cảnh / Thời tiết: Giao mùa, thời tiết thay đổi thất thường hoặc độ ẩm cao làm virus và vi khuẩn đường hô hấp bùng phát.");
                diag.AppendLine("  - Nhóm thuốc mua nhiều: Thuốc hạ sốt giảm đau (Paracetamol), Kháng sinh đường hô hấp, Siro ho thảo dược, Kháng Histamin và Vitamin C.");
                diag.AppendLine("  - Khuyến nghị Dược sĩ: Kiểm tra tồn kho nhóm kháng sinh, thuốc hạ sốt; nhắc nhở khách giữ ấm đường thở, súc họng nước muối thường xuyên.");
            }
            else if (maxScore == digScore)
            {
                diag.AppendLine("  Kết luận cụ thể: Đang là MÙA GIA TĂNG BỆNH LÝ ĐƯỜNG TIÊU HÓA (Rối loạn tiêu hóa, Tiêu chảy, Ngộ độc thực phẩm, Viêm dạ dày).");
                diag.AppendLine("  - Ngữ cảnh / Thời tiết: Thời tiết nóng ẩm, vi khuẩn phát triển nhanh trong thực phẩm hoặc thay đổi thói quen ăn uống, sinh hoạt.");
                diag.AppendLine("  - Nhóm thuốc mua nhiều: Men vi sinh đường ruột, Oresol bù nước điện giải, Thuốc giảm tiết acid dịch vị (PPI/Antacid) và thuốc cầm tiêu chảy.");
                diag.AppendLine("  - Khuyến nghị Dược sĩ: Hướng dẫn kỹ người bệnh pha Oresol đúng tỷ lệ nước, uống men vi sinh cách giờ kháng sinh và đảm bảo an toàn vệ sinh thực phẩm.");
            }
            else if (maxScore == jointScore)
            {
                diag.AppendLine("  Kết luận cụ thể: GIA TĂNG CÁC BỆNH LÝ CƠ XƯƠNG KHỚP & ĐAU NHỨC MÃN TÍNH.");
                diag.AppendLine("  - Ngữ cảnh / Thời tiết: Thời tiết chuyển lạnh/ẩm hoặc tập khách hàng của nhà thuốc có tỷ lệ người cao tuổi, lao động thể lực cao.");
                diag.AppendLine("  - Nhóm thuốc mua nhiều: Thuốc kháng viêm giảm đau (NSAIDs), Glucosamin tái tạo sụn khớp, Canxi và các thuốc bôi/dầu xoa bóp ngoài da.");
                diag.AppendLine("  - Khuyến nghị Dược sĩ: Lưu ý khách hàng uống thuốc sau bữa ăn no để bảo vệ dạ dày, kết hợp chế độ tập luyện nhẹ nhàng.");
            }
            else if (maxScore == chronicScore)
            {
                diag.AppendLine("  Kết luận cụ thể: NHU CẦU DUY TRÌ ĐIỀU TRỊ BỆNH MÃN TÍNH (Huyết áp, Tim mạch, Tiểu đường).");
                diag.AppendLine("  - Ngữ cảnh / Thời tiết: Khách hàng định kỳ mua tái đơn theo chu kỳ điều trị tháng theo chỉ định của chuyên gia y tế.");
                diag.AppendLine("  - Nhóm thuốc mua nhiều: Thuốc kiểm soát huyết áp, đường huyết, mỡ máu và tim mạch.");
                diag.AppendLine("  - Khuyến nghị Dược sĩ: Nhắc nhở người bệnh uống thuốc đúng giờ cố định mỗi ngày, theo dõi huyết áp/đường huyết định kỳ và kiểm tra đơn chỉ định.");
            }
            else
            {
                diag.AppendLine("  Kết luận cụ thể: GIA TĂNG NHU CẦU TĂNG CƯỜNG SỨC ĐỀ KHÁNG & BỒI BỔ THỂ TRẠNG TỔNG THỂ.");
                diag.AppendLine("  - Ngữ cảnh / Thời tiết: Khách hàng quan tâm phòng bệnh chủ động, phục hồi thể lực sau giai đoạn làm việc căng thẳng hoặc ốm dậy.");
                diag.AppendLine("  - Nhóm thuốc mua nhiều: Vitamin tổng hợp, Hoạt huyết dưỡng não, Bổ gan và khoáng chất thiết yếu.");
                diag.AppendLine("  - Khuyến nghị Dược sĩ: Tư vấn liều dùng bổ sung phù hợp theo độ tuổi, tránh lạm dụng quá liều và kết hợp chế độ dinh dưỡng lành mạnh.");
            }

            return diag.ToString().TrimEnd();
        }
    }
}
