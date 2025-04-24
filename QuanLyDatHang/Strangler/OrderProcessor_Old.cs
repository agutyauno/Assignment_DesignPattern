using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDatHang.Models;

namespace QuanLyDatHang.Strangler
{
    public class OrderProcessor_Old
    {
        public void Process(Order order)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Processing order using OLD system...");
        }
    }
}
