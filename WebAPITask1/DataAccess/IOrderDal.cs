using WebAPITask1.Entities;

namespace WebAPITask1.DataAccess
{
    public interface IOrderDal : IEntityRepository<Order>
    {
        List<Order> GetProductsWithDetailts();
    }
}
