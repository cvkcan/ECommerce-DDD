using ECommerce_DDD.Application.Repositories.CustomerRepository;

namespace ECommerce_DDD.Infrastructure.Repositories.CustomerRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(1);
        }
    }
}
