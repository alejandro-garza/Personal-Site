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

        public IActionResult Index()
        {

            var model = new EmploymentViewModel();
            model.myEmployers = new List<EmploymentEntry>();
            model.myEmployers.Add(new EmploymentEntry()
            {
                Company = "Nansen",
                Position = " / Quality Assurance Intern",
                StartDate = new DateTime(2020, 7, 1),
                Location = "CHICAGO, ILLINIOS",
                DetailA = "Monitored and worked on tickets within the Agile sprint process.",
                DetailB = "Assisted in proposals for potential clients.",
                DetailC = "Executed tests on bugs at all stages of production."
            });

            model.myEmployers.Add(new EmploymentEntry()
            {
                Company = "Walmart",
                Position = " / Sales Associate",
                Location = "SAN ANTONIO, TEXAS",
                StartDate = new DateTime(2016, 3, 1),
                EndDate = new DateTime(2020, 6, 1),
                DetailA = "Provided exemplary customer service adhering to company ethics and guidelines.",
                DetailB = "Assisted in assigned departments where needed.",
                DetailC = "Trained and managed new Sales Associates."
            });

            model.myEmployers.Add(new EmploymentEntry()
            {
                Company = "Cost Plus World Market",
                Position = " / Sales Associate",
                Location = "SAN ANTONIO, TEXAS",
                StartDate = new DateTime(2015, 9, 1),
                EndDate = new DateTime(2016, 3, 1),
                DetailA = "Promoted and sold merchandise while servicing customers and answering all customer inquiries.",
                DetailB = "Assisted with cleaning, organizing, and cash handling."
            });

            model.myEmployers = model.myEmployers.OrderByDescending(employer => employer.StartDate).ToList();

            return View(model);

        }


    }
}
