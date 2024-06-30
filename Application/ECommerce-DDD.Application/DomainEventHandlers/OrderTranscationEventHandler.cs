using ECommerce_DDD.Application.Repositories.CustomerRepository;
using ECommerce_DDD.Domain.AggregateModels.CustomerModels;
using ECommerce_DDD.Domain.Events.OrderTransactionDomainEvent;
using MediatR;

namespace ECommerce_DDD.Application.DomainEventHandlers
{
    public class OrderTranscationEventHandler : INotificationHandler<OrderTransactionDomainEvent>
    {
        private readonly ICustomerRepository _customerRepository;

        public OrderTranscationEventHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task Handle(OrderTransactionDomainEvent notification, CancellationToken cancellationToken)
        {
            if (notification.Order.Customer.Name == "")
            {
                //create a new customer
            }   
            return Task.CompletedTask;
        }
    }
}
