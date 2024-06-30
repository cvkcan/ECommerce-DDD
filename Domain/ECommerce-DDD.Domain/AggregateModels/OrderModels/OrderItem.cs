using ECommerce_DDD.Domain.SeedWorks;

namespace ECommerce_DDD.Domain.AggregateModels.OrderModels
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public OrderItem(int quantity, decimal price)
        {
            if (quantity <= 0)
                throw new Exception("Quantity can not be less than or equal to zero");
            if (price < 0)
                throw new Exception("Price can not be less than zero");
            Quantity = quantity;
            Price = price;
        }
    }
}
