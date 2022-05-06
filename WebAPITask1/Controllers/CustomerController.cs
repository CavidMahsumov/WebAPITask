using Microsoft.AspNetCore.Mvc;
using WebAPITask1.DataAccess;

namespace WebAPITask1.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerDal _customerDal;

        public CustomerController(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            var customers = _customerDal.GetList();
            return Ok(customers);
        }
        //[HttpGet("{customerId}")]
        //public IActionResult Get(int customerId)
        //{
        //    try
        //    {
        //        var customer = _customerDal.Get(p => p.CustomerID == customerId.ToString());
        //        if (customer == null)
        //        {
        //            return NotFound($"There is not product with id : {customerId}");
        //        }
        //        return Ok(customer);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    return BadRequest();
        //}

    }
}
