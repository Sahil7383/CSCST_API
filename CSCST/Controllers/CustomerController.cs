using CSCST.BusinessEntities;
using CSCST.BussinessLogic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSCST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerManager _customerManager;

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }


        [HttpGet, Route("Customers")]
        public IActionResult GetCustomers()
        {
            var customers = _customerManager.GetCustomers();
            if (customers == null || !customers.Any())
            {
                return NotFound();
            }
            return Ok(customers);
        }

        [HttpGet, Route("Customers{id}")]
        public IActionResult GetCustomersById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            var customer = _customerManager.GetCustomersById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost, Route("AddCustomers")]
        public IActionResult Post([FromBody] CustomerViewModel customerviewmodel)
        {
            if (customerviewmodel is null)
            {
                return Ok(
                    new{
                    StatusCode=400,
                    Messeage="Registration Failed"
                    });
            }
            
            _customerManager.AddCustomer(customerviewmodel);
            return Ok(new
            {
                StatusCode = 200,
                Messeage = "Registration Successfully!"

            });
        }


        [HttpPost,Route("Login")]
        public IActionResult Post([FromBody] LoginViewModel loginViewModel)
        {
            bool isCorrect=_customerManager.CustomerLogin(loginViewModel.email, loginViewModel.password);
            if(isCorrect)
            {
                return Ok(new
                {
                    StatusCode = 200,
                    Messeage = "Login Successfull!!"

                });

            }
            else
            {
                return Ok(new
                {
                    StatusCode = 400,
                    Messeage = "Login Failed!"

                });

            }
        }
    }
}
