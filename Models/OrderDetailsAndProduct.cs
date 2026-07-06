namespace Pharmacy_Nhom1.Models
{
    public class OrderDetailsAndProduct
    {
        public long OrderDetailID { get; set; }
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get { return Quantity * Price; } }
    }
}
