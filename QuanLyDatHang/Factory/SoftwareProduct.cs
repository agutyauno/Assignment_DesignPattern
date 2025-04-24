namespace QuanLyDatHang.Factory
{
    internal class SoftwareProduct : IProduct
    {
        public void Delivery() => Console.WriteLine("Delivering software...");
    }
}
