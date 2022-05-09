using Microsoft.AspNetCore.Mvc;
using WebAPITask1.DataAccess;
using WebAPITask1.Entities;

namespace WebAPITask1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
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

        [HttpGet("customerId")]
        public IActionResult Get(int customerId)
        {
            try
            {
                var customer = _customerDal.Get(c => c.CustomerId == customerId);
                if (customer == null)
                {
                    return NotFound($"There is not product with id : {customerId}");
                }
                return Ok(customer);
            }
            catch (Exception)
            {
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            try
            {
                _customerDal.Add(customer);
                return new StatusCodeResult(200);
            }
            catch (Exception)
            {
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put(Customer customer)
        {
            try
            {
                _customerDal.Update(customer);
                return Ok();
            }
            catch (Exception)
            {
            }
            return BadRequest();
        }

        [HttpDelete("{customerId}")]
        public IActionResult Delete(int customerId)
        {
            try
            {
                _customerDal.Delete(new Customer { CustomerId = customerId });
                return Ok();
            }
            catch (Exception)
            {
            }
            return BadRequest();
        }


        [HttpGet("GetProductsDetails")]
        public IActionResult GetCustomersWithDetails()
        {
            try
            {
                var result = _customerDal.GetProductsWithDetailts();
                return Ok(result);
            }
            catch (Exception)
            {
            }
            return BadRequest();
        }


        [HttpGet("customerId2")]
        public IActionResult GetCustomersWithDetailsById(int customerId2)
        {
            try
            {
                var results = _customerDal.GetProductsWithDetailtsById(customerId2);
                return Ok(results);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("isOk")]
        public IActionResult OrderByCustomer(bool isOk)
        {
            if (isOk)
            {
                var results = _customerDal.AlphabeticOrderBy();
                return Ok(results);
            }
            else
            {
                var result = _customerDal.GetList();
                return Ok(result);

            }
        }


    }
}
