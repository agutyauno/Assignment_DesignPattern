namespace QuanLyDatHang.Factory
{
    internal class CloudServiceFactory : IFactory
    {
        public IProduct CreateProduct()
        {
            return new CloudServiceProduct();
        }
    }
}