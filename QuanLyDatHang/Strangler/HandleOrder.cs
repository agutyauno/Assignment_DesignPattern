using QuanLyDatHang.Models;
namespace QuanLyDatHang.Strangler
{
    public class OrderHandleFacades
    {
        public void HandleOrder(Order order)
        {
            if (order.OrderMode == "Legacy")
                new OrderProcessor_Old().Process(order);
            else
                new OrderProcessor_New().Process(order);
        }
    }
}