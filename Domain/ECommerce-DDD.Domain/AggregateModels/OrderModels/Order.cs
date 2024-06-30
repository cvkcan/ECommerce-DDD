using ECommerce_DDD.Domain.AggregateModels.CustomerModels;
using ECommerce_DDD.Domain.SeedWorks;

namespace ECommerce_DDD.Domain.AggregateModels.OrderModels
{
    public class Order : BaseEntity, IAggregateRoot
    {
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Address Address { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Order(DateTime createdDate, string description, string status, Address address, ICollection<OrderItem> orderItems, Customer customer)
        {
            if (createdDate > DateTime.Now)
                throw new Exception("Wrong Date");
            if (address.ZipCode == "")
                throw new Exception("Zipcode can not be empty");
            if (address.ZipCode.Length > 5)
                throw new Exception("Wrong Zipcode");
            if (status == "")
                throw new Exception("Status can not be empty");
            if (orderItems.Count == 0)
                throw new Exception("Order must have at least one item");
            CreatedDate = createdDate;
            Description = description;
            Status = status;
            Address = address;
            OrderItems = orderItems;
            Customer = customer;
        }
        public void AddOrderItem(int quantity, decimal price)
        {
            var orderItem = new OrderItem(quantity, price);
            OrderItems.Add(orderItem);
        }
    }
}
