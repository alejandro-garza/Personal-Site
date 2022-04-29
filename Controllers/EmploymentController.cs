using Contentful.Core;
using Contentful.Core.Models;
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
    public class EmploymentController : Controller
    {
        private readonly ILogger<EmploymentController> _logger;

        private HtmlRenderer _htmlRenderer;

        public EmploymentController(ILogger<EmploymentController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            var httpClient = new HttpClient();
            var client = new ContentfulClient(httpClient, "dwKsdh8rYhTGQ1VcLAUz2fYU8XzF_FsD-DBRtuyInwA", "8CPcrfazWE_piqt-gTUPx9YaSxMZZ_BznwMvKVkS4oY", "zl4g8ja5q050");

            
            var entries = client.GetEntries<EmploymentEntry>().Result.ToList();

            /****
            For 
            ****/
            //var entry = client.GetEntry<EmploymentEntry>("3ALMPJjdZ3FErtK7j8llTd").Result;
            //Console.WriteLine(entry.Company);

            var model = new EmploymentViewModel();

            _htmlRenderer = new HtmlRenderer();

            foreach (var entry in entries)
            {
                entry.DetailsString = _htmlRenderer.ToHtml(entry.Details).Result;
            }

            model.myEmployers = entries;

            model.myEmployers = model.myEmployers.OrderByDescending(employer => employer.StartDate).ToList();

            return View(model);

        }

    }
}
