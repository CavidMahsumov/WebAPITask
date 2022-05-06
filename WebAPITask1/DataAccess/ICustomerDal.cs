using WebAPITask1.Entities;

namespace WebAPITask1.DataAccess
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<Customer> GetProductsWithDetailts();
    }
}
