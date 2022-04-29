using Contentful.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectApp.Models;
using ProjectApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace ProjectApp.Controllers
{
    public class EducationController : Controller
    {
        private readonly ILogger<EducationController> _logger;
        private readonly IEducationService _educationService;

        public EducationController(ILogger<EducationController> logger, IEducationService educationService)
        {
            _logger = logger;
            _educationService = educationService;
        }


        public IActionResult Index()
        {

            var model = new EducationViewModel();

            model.myEducation = _educationService.GetAllEntries();

            _logger.Log(LogLevel.Critical, "");

            return View(model);
        }

    }
}
