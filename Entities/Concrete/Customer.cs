using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustumerId { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

    }
}