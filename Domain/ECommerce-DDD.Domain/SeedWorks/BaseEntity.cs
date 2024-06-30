using MediatR;

namespace ECommerce_DDD.Domain.SeedWorks
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public ICollection<INotification> DomainEvents{ get; set; }
        public void AddDomainEvent(INotification eventItem)
        {
            DomainEvents = DomainEvents ?? new List<INotification>();
            DomainEvents.Add(eventItem);
        }   
    }
}
