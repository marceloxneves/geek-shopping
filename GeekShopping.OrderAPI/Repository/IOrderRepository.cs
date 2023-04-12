
using GeekShopping.OrderAPI.Model;

namespace GeekShopping.OrderAPI.Repository
{
    public interface IOrderRepository
    {
        public interface IOrderRepository
        {
            Task<bool> AddOrder(OrderHeader header);
            Task UpdateOrderPaymentStatus(long orderHeaderId, bool paid);
        }
    }
}
