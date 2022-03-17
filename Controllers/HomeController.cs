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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() // ? Referenced in index.cshtml
        {
            //create a home view model
            var model = new HomeViewModel()
            {
                Fullname = "Ismael Alejandro Garza",
                Profile = "Profile",
                Title = "Prospective Developer",
                Background = "Background"
            };

            //this returns the view and provides the model for it
            return View(model);
        }

        public IActionResult Employment()
        {

            var model = new EmploymentViewModel();
            model.myEmployers = new List<EmploymentEntry>();
            model.myEmployers.Add(new EmploymentEntry()
            {
                CurrentCompany = "Nansen",
                Position = "/ Quality Assurance Intern",
                Year = "July 2020 - September 2020,  CHICAGO",
                DetailA = "Monitored and worked on tickets within the Agile sprint process.",
                DetailB = "Assisted in proposals for potential clients.",
                DetailC = "Executed tests on bugs at all stages of production."
            });

            model.myEmployers.Add(new EmploymentEntry()
            {
                Company = "Walmart",
                Position = " / Sales Associate",
                Year = "March 2016 - June  2020,  SAN ANTONIO",
                DetailA = "Provided exemplary customer service adhering to company ethics and guidelines.",
                DetailB = "Assisted in assigned departments where needed.",
                DetailC = "Trained and managed new Sales Associates."
            });

            model.myEmployers.Add(new EmploymentEntry()
            {
                Company = "Cost Plus World Market",
                Position = " / Sales Associate",
                Year = "November 2015 - March 2016,  SAN ANTONIO",
                DetailA = "Promoted and sold merchandise while servicing customers and answering all customer inquiries.",
                DetailB = "Assisted with cleaning, organizing, and cash handling."
            });

            return View(model);

        }

        public IActionResult Education()
        {

            var model = new EducationViewModel();
            model.myEducation = new List<EducationEntry>();

            model.myEducation.Add(new EducationEntry()
            {
                Program = "Bootcamp Prep Program",
                Detail = "  / App Academy (2020)",
                ProgramYear = "July 2020 - August 2020,  ONLINE",
            });

            model.myEducation.Add(new EducationEntry()
            {
                School = "Northwest Vista College",
                Degree = " / Candidate for BA in Computer Science",
                Year = "August 2019 - August 2020,  SAN ANTONIO"
            });

            model.myEducation.Add(new EducationEntry()
            {
                School = "Grinnell College",
                Degree = " / Credits in Biochemistry",
                Year = "August 2012 - May 2013,  GRINNELL"
            });

            return View(model);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
