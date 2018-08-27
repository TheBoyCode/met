using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using ASPNetCoreForms.models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace met.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LoginModel model)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                message = "ID " + model.ID + " Login " + model.Login + " Password " + model.Password + " created successfully";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }
    }
}
