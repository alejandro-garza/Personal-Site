using System;
namespace ProjectApp.Models
{
    public class EmploymentEntry
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DetailA { get; set; }
        public string DetailB { get; set; }
        public string DetailC { get; set; }

        public EmploymentEntry()
        {


        }
    }
}
