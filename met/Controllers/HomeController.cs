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
        public IActionResult CreateRegist(RegistrationModel model)
        {
            string message = "";
            validationService = new ValidationService();
            if (ModelState.IsValid && validationService.ValidationRegistration(model))
            {
                return View();
                //message = "ok";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            
            return Content(message);
        }
        [HttpPost]
        public IActionResult Authorization(LoginModel model)
        {
            string message = "";
            validationService = new ValidationService();
            if (ModelState.IsValid && validationService.ValidationLogin(model.Login) && validationService.ValidationPassword(model.Password))
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
