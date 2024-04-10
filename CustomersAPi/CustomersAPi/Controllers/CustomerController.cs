using Microsoft.AspNetCore.Mvc;
using CustomersAPi.Dtos;
using CustomersAPi.Repositories;

namespace CustomersAPi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly SystemContext _systemContext;

        public CustomerController(SystemContext systemContext) { 
        
            _systemContext = systemContext;
        }

        //api/customer/
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]

        public async Task<IActionResult> GetCustomers()
        { 
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetCustomer(long id)
        {
            //throw new NotImplementedException();

            CustomerEntity result = await _systemContext.Get(id);

            return new OkObjectResult(result.toDto());
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type =typeof(bool))]

        public async Task<IActionResult> DeleteCustomer(long Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto customer)
        {

            CustomerEntity result = await _systemContext.Add(customer);

            return new CreatedResult($"http://localhost:7180/api/customer/{result.Id}", null);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

    }
}
