namespace WebAPITask1.Models
{
    public class CustomerOrderModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderName { get; set; }
    }
}
