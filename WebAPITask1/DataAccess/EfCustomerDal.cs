using WebAPITask1.Entities;

namespace WebAPITask1.DataAccess
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthWindContext>, ICustomerDal
    {
        public List<Customer> GetProductsWithDetailts()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from p in context.Customers
                             select new Customer
                             {
                                 CustomerId =p.CustomerId,
                                  Address = p.Address,
                                  City = p.City,
                                  CompanyName = p.CompanyName,
                                  Country = p.Country,
                                  Phone = p.Phone,
                                  PostalCode = p.PostalCode,
                                  Region = p.Region,

                             };
                return result.ToList();
            }

        }
    }
}
