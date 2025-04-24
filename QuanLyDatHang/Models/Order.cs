namespace QuanLyDatHang.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductType { get; set; }
        public string OrderMode { get; set; } // Legacy | Modern
    }
}
