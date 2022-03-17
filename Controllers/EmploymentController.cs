using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Controllers
{
    public class EmploymentController : Controller
    {
        private readonly ILogger<EmploymentController> _logger;

        public EmploymentController(ILogger<EmploymentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Employment() // ? Referenced in index.cshtml
        {
            //create a home view model
            var model2 = new EmploymentViewModel()
            {
                //Company = "Ismael Alejandro Garza",
                //Year = "Profile",
                //Detail1 = "Prospective Developer",
                //Detail2 = "Background"
                Fullname = "Ismael Alejandro Garza",
                Profile = "Profile",
                Title = "Prospective Developer",
                Background = "Background"
            };

            //this returns the view and provides the model for it
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
