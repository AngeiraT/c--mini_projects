using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContactApp.Models;
using Microsoft.Extensions.Logging;
using ContactApp.ViewModels;
using System.Collections.Generic;
using System;

namespace ContactApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Redirect to the login action
            return RedirectToAction("Login");
        }

        public IActionResult Logout()
        {
            // Redirect to the login page
            return RedirectToAction("Login");
        }


        public IActionResult Login()
        {
            // Display the login view
            return View();
        }

        public IActionResult Main()
        {
            // Display the Main view
            MainViewModel viewModel = new MainViewModel();

            // Set the username
            viewModel.Username = "AngeiraQuiles"; // Replace with the actual username

            // Populate the contacts list
            viewModel.Contacts = new List<ContactViewModel>
            {
                new ContactViewModel
                {
                    ContactID = 1,
                    Name = "Lady LiLa",
                    Phone = "1234567890",
                    Fax = "9876543210",
                    Email = "lady@example.com",
                    Notes = "Work Partner",
                    LastUpdateDate = DateTime.Now,
                    LastUpdateUserName = "AngeiraQuiles"
                },
                new ContactViewModel
                {
                    ContactID = 2,
                    Name = "Juan Del Pueblo",
                    Phone = "9876543210",
                    Fax = "1234567890",
                    Email = "pueblo@example.com",
                    Notes = "Actualizado",
                    LastUpdateDate = DateTime.Now,
                    LastUpdateUserName = "AngeiraQuiles"
                }
                // Add more contacts as needed
            };

            return View(viewModel);
        }

        public IActionResult AddContact()
        {
            var contactModel = new ContactViewModel();

            return PartialView("Contact", contactModel);
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // Perform authentication logic
            if (ModelState.IsValid)
            {
                // Redirect to the main action with the authenticated username
                return RedirectToAction("Main");
            }

            return View(model);
        }

    }
}
