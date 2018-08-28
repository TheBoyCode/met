using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using met.Models;
using Microsoft.AspNetCore.Mvc;
//using ASPNetCoreForms.models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace met.Controllers
{
    public class HomeController : Controller
    {
        private ValidationService validationService;
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(LoginModel model)
        {
            validationService = new ValidationService();
            string message = "";

            if (ModelState.IsValid && validationService.ValidationLogin(model.Login) &&
                validationService.ValidationPassword(model.Password))
            {
                //message = "ID " + model.ID + " Login " + model.Login + " Password " + model.Password + " created successfully";
                return View();
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            
            return Content(message);
        }
        [HttpPost]
        public IActionResult CreateRegistration(RegistrationModel model)
        {
            string message = "";
            validationService = new ValidationService();
            if (ModelState.IsValid && validationService.ValidationRegistration(model))
            {
                message = "ok";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }
    }
}
