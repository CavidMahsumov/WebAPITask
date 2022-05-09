using WebAPITask1.Entities;
using WebAPITask1.Models;

namespace WebAPITask1.DataAccess
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        public List<CustomerOrderModel> GetProductsWithDetailts();
        public List<OrderModel> GetProductsWithDetailtsById(int customerId);

        public List<CustomerModel> AlphabeticOrderBy();

    }
}
