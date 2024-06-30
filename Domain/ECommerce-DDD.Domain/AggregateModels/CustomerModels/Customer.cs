using ECommerce_DDD.Domain.SeedWorks;

namespace ECommerce_DDD.Domain.AggregateModels.CustomerModels
{
    public class Customer : BaseEntity
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public bool IsTurkishCitizen { get; private set; }
        public string CitizenName { get; private set; }
        public Customer(string name, string surname, bool isTurkishCitizen, string citizenName)
        {
            if (name == "")
                throw new Exception("Name can not be null or empty");
            if (surname == "")
                throw new Exception("Surname can not be null or empty");
            if (isTurkishCitizen)
                citizenName = "T.C.";
            else
            {
                if (citizenName == "")
                    throw new Exception("Citizen Name can not be null or empty");
                CitizenName = citizenName;
            }
            Name = name;
            Surname = surname;
            IsTurkishCitizen = isTurkishCitizen;
        }
    }
}
