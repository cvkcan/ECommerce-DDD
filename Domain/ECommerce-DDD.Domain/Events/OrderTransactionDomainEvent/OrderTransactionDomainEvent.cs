using ECommerce_DDD.Domain.AggregateModels.CustomerModels;
using ECommerce_DDD.Domain.AggregateModels.OrderModels;
using MediatR;

namespace ECommerce_DDD.Domain.Events.OrderTransactionDomainEvent
{
    public class OrderTransactionDomainEvent : INotification
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
        public OrderTransactionDomainEvent(Customer customer, Order order)
        {
            Customer = customer;
            Order = order;
        }
    }
}
