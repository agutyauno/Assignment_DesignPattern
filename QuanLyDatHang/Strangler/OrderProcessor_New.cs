using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDatHang.Models;

namespace QuanLyDatHang.Strangler
{
    public class OrderProcessor_New
    {
        public void Process(Order order)
        {
/*            IFactory factory = order.ProductType switch
            {
                "Software" => new SoftwareFactory(),
                "CLoudService" => new CloudServiceFactory(),
                _ => throw new Exception("Invalid product type")
            };

            var product = factory.CreateProduct();
            product.Deliver();*/
        }
    }   
}
