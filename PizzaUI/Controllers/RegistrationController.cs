using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PizzaUI.BusinessLogic;

namespace PizzaAppUI.Controllers
{
    public class RegistrationController : Controller
    {
        
        public RegistrationController()
        {
           
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([Bind("FirstName,LastName,Email,Phone,Address,City,State,ZipCode,Password")] Customer customer)
        {
            customer.DateCreated = DateTime.Now;
            customer.OrdersList = new List<Order>();
            customer.PaymentList = new List<Payment>();
              

            if (ModelState.IsValid)
            { 
                var result = Operations.PostToAPI<Customer>(new Uri("http://localhost:51953/api/Customers/"), customer);
                result.EnsureSuccessStatusCode();
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Register)); ;
                    }
                    ModelState.AddModelError(string.Empty, "Server Error. Registration Failed. Please contact administrator.");
            }
            
            return View(customer);
        }
    }
}