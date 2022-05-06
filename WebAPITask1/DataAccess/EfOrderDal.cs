using WebAPITask1.Entities;

namespace WebAPITask1.DataAccess
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthWindContext>, IOrderDal
    {
        public List<Order> GetProductsWithDetailts()
        {
            //using (NorthWindContext context = new NorthWindContext())
            //{
            //    var result = from p in context.Orders
            //                 join c in context.Customers
            //                 on p.CustomerID equals c.CustomerId
            //                 select new Order
            //                 {
            //                     OrderID = p.OrderID,
            //                     CustomerID = c.CustomerId,
            //                     OrderDate = p.OrderDate,
            //                     RequiredDate = p.RequiredDate,
            //                     ShipAdress = p.ShipAdress,
            //                     ShipCity = p.ShipCity,
            //                     ShipCountry = p.ShipCountry,
            //                     ShipName = p.ShipName,
            //                     ShippedDate=p.ShippedDate,
            //                     ShipPostalCode = p.ShipPostalCode,
            //                     ShipRegion = p.ShipRegion,
            //                     EmployeeID = p.EmployeeID,
            //                 };
            //    return result.ToList();
            //}
            return new List<Order>();
        }
    }
}
