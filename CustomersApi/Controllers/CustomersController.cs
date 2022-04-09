using Microsoft.AspNetCore.Mvc;
using CustomersApi.Dtos;

namespace CustomersApi.Controllers
{   
    //[controller] se traduce automaticamente a customers
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {

        [HttpGet("{id}")]
        public async Task<Customer> GetCustomer(long id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<Customer> CreateCustomer(CreateCustomer customer)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
