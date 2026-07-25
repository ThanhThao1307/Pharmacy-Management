namespace Pharmacy_Nhom1.Models
{
    public class OrderDetailsAndProduct
    {
        public long OrderDetailID { get; set; }
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SoldUnit { get; set; } = string.Empty;
        public int ConversionRate { get; set; } = 1;
        public string DisplayName => string.IsNullOrEmpty(SoldUnit) || SoldUnit == "Đơn vị cơ bản" ? Name : $"{Name} ({SoldUnit})";
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get { return Quantity * Price; } }
    }
}
