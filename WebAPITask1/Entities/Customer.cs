using System.ComponentModel.DataAnnotations;

namespace WebAPITask1.Entities
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; };
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

    }
}
