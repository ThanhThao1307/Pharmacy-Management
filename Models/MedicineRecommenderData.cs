using System;
using Microsoft.ML.Data;

namespace Pharmacy_Nhom1.Models
{
    // Lớp chứa dữ liệu huấn luyện (lấy từ lịch sử mua hàng trong CSDL)
    public class MedicineRating
    {
        [LoadColumn(0)]
        public float CustomerId { get; set; }

        [LoadColumn(1)]
        public float ProductId { get; set; }

        [LoadColumn(2)]
        public float QuantityBought { get; set; } // Số lượng đã mua đóng vai trò như điểm đánh giá (Rating)
    }

    // Lớp chứa kết quả AI dự đoán ra
    public class MedicineRatingPrediction
    {
        public float QuantityBought; // Giá trị thực tế
        public float Score;          // Điểm AI dự đoán (càng cao nghĩa là khách càng có xu hướng mua nhiều)
    }
}
