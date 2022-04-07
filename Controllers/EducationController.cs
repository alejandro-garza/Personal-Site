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
    public class EducationController : Controller
    {
        private readonly ILogger<EducationController> _logger;

        public EducationController(ILogger<EducationController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            var model = new EducationViewModel();
            model.myEducation = new List<EducationEntry>();
            model.myEducation.Add(new EducationEntry()
            {
                Institution = "App Academy",
                Program = " / Bootcamp Prep Program",
                Location = "ONLINE",
                StartDate = new DateTime(2020, 7, 1),
                EndDate = new DateTime(2020, 12, 31)
            });

            model.myEducation.Add(new EducationEntry()
            {
                Institution = "Northwest Vista College",
                Program = " / Candidate for BA in Computer Science",
                Location = "SAN ANTONIO, TEXAS",
                StartDate = new DateTime(2019, 8, 1),
                EndDate = new DateTime(2020, 8, 31)
            });

            model.myEducation.Add(new EducationEntry()
            {
                Institution = "Grinnell College",
                Program = " / Credits in Biochemistry",
                Location = "GRINNELL, IOWA",
                StartDate = new DateTime(2012, 8, 1),
                EndDate = new DateTime(2013, 5, 1)
            });

            model.myEducation = model.myEducation.OrderByDescending(employer => employer.StartDate).ToList();

            return View(model);
        }

    }
}
