using System.ComponentModel.DataAnnotations;

namespace WebAPITask1.Entities
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Adress { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

    }
}
