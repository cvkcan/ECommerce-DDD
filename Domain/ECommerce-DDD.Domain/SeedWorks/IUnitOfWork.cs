namespace ECommerce_DDD.Domain.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
