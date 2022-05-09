using WebAPITask1.Entities;
using WebAPITask1.Models;

namespace WebAPITask1.DataAccess
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthWindContext>, ICustomerDal
    {
        public List<CustomerModel> AlphabeticOrderBy()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from c in context.Customers
                             orderby c.CustomerName
                             select new CustomerModel
                             {
                                 CustomerId = c.CustomerId,
                                 CustomerName = c.CustomerName,
                             };
                return result.ToList();
            }
        }

        public List<CustomerOrderModel> GetProductsWithDetailts()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from c in context.Customers
                             join o in context.Orders
                             on c.CustomerId equals o.CustomerId
                             select new CustomerOrderModel
                             {
                                 CustomerId = c.CustomerId,
                                 CustomerName = c.CustomerName,
                                 OrderDate = o.OrderDate,
                                 OrderName = o.OrderName,
                             };
                return result.ToList();
            }
        }

        public List<OrderModel> GetProductsWithDetailtsById(int customerId)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from o in context.Orders
                             where o.CustomerId == customerId
                             select new OrderModel
                             {
                                 OrderId = o.OrderId,
                                 OrderDate = o.OrderDate,
                                 OrderName = o.OrderName,
                             };
                return result.ToList();
            }
        }

    }
}

