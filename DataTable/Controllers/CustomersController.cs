using DataTable.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DataTable.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View(GetAllCustomers());
        }
        
        public List<CustomerDTO> GetAllCustomers()
        {
            var customers = new List<CustomerDTO>
            {
                new CustomerDTO
                {
                    Gender = "Male",
                    CustomerId = 1,
                    CustomerName = "Henry Kamwamba"
                }
            };
            Response.StatusCode = customers.Any() ? (int)HttpStatusCode.OK : (int)HttpStatusCode.BadRequest;
            return customers;
        }
        
        public JsonResult GetCustomers()
        {
            return Json(GetAllCustomers());
        }
    }
}

