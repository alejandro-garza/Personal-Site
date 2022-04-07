using System;
namespace ProjectApp.Models
{
    public class EducationEntry
    {
        public string Institution { get; set; }
        public string Program { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public EducationEntry()
        {


        }
    }
}
