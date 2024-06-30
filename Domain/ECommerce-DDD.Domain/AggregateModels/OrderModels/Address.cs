using ECommerce_DDD.Domain.SeedWorks;

namespace ECommerce_DDD.Domain.AggregateModels.OrderModels
{
    public class Address : ValueObject
    {
        public string City { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public Address() 
        {
        }
        public Address(string city, string country, string zipCode)
        {
            City = city;
            Country = country;
            ZipCode = zipCode;
        }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;
            yield return Country;
            yield return ZipCode;
        }
    }
}
