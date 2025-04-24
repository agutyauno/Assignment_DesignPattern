namespace QuanLyDatHang.Factory
{
    internal class SoftwareFactory : IFactory
    {
        public IProduct CreateProduct()
        {
            return new SoftwareProduct();
        }
    }
}