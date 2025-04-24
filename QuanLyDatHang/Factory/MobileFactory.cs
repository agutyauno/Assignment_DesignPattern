namespace QuanLyDatHang.Factory
{
    internal class MobileFactory : IFactory
    {
        public IProduct CreateProduct()
        {
            return new MobileProduct();
        }
    }
}