using example_api_01.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace example_api_01.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize] // Autorizacion 
    public class CustomersController : Controller
    {
        [HttpGet()]
        public async Task<CustomersDto> GetCustomersDto()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<CustomersDto> GetCustomersDto(long id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteCustomersDto(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<bool> CreateCustomersDto(CreateCustomersDto customers)
        {
            throw new NotImplementedException();
        }

        [HttpPut]   // Actualzar
        public async Task<bool> CreateCustomersDto(CustomersDto customers)
        {
            throw new NotImplementedException();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
