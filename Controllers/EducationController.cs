using Contentful.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectApp.Models;
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

        public EducationController(ILogger<EducationController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            var httpClient = new HttpClient();
            var client = new ContentfulClient(httpClient, "dwKsdh8rYhTGQ1VcLAUz2fYU8XzF_FsD-DBRtuyInwA", "8CPcrfazWE_piqt-gTUPx9YaSxMZZ_BznwMvKVkS4oY", "zl4g8ja5q050");

            var entry = client.GetEntry<EducationEntry>("kaoCkG3tC6w2Lnk7FO3rr").Result;
            var entries = client.GetEntries<EducationEntry>().Result.ToList();

            Console.WriteLine(entry.Institution);

            var model = new EducationViewModel();

            model.myEducation = entries;

            model.myEducation = model.myEducation.OrderByDescending(employer => employer.StartDate).ToList();

            return View(model);
        }

    }
}
