using CustomerOnboardingApi.Application.Interfaces;
using CustomerOnboardingApi.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CustomerOnboardingApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService customerService;
        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            try
            {
                var created = customerService.Create(customer);
                return Ok(created);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { errors = ex.Message });
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var customer = await customerService.GetById(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await customerService.GetAll());
        }
    }
}
