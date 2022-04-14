using System;
using Contentful.Core.Models;

namespace ProjectApp.Models
{
    public class EmploymentEntry
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Document Details { get; set; }

        public EmploymentEntry()
        {


        }
    }
}
