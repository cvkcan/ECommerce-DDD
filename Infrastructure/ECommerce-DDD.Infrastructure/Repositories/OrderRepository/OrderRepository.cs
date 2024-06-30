using ECommerce_DDD.Application.Repositories.OrderRepository;

namespace ECommerce_DDD.Infrastructure.Repositories.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(1);
        }
    }
}
