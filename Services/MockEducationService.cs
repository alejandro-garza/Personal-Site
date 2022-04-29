using System;
using System.Collections.Generic;
using ProjectApp.Models;

namespace ProjectApp.Services
{
    public class MockEducationService : IEducationService
    {
        private List<EducationEntry> _entries;

        public MockEducationService()
        {
            _entries = new List<EducationEntry>();
            _entries.Add(new EducationEntry()
            {
                Institution = "Mock App Academy",
                Program = " / Bootcamp Prep Program",
                Location = "ONLINE",
                StartDate = new DateTime(2020, 7, 1),
                EndDate = new DateTime(2020, 12, 31)
            });

            _entries.Add(new EducationEntry()
            {
                Institution = "Mock Northwest Vista College",
                Program = " / Candidate for BA in Computer Science",
                Location = "SAN ANTONIO, TEXAS",
                StartDate = new DateTime(2019, 8, 1),
                EndDate = new DateTime(2020, 8, 31)
            });

            _entries.Add(new EducationEntry()
            {
                Institution = "Mock Grinnell College",
                Program = " / Credits in Biochemistry",
                Location = "GRINNELL, IOWA",
                StartDate = new DateTime(2012, 8, 1),
                EndDate = new DateTime(2013, 5, 1)
            });
        }

        public List<EducationEntry> GetAllEntries()
        {
            return _entries;
        }

        public EducationEntry GetMostRecentEntry()
        {
            return new EducationEntry()
            {
                Institution = "Mock App Academy",
                Program = " / Bootcamp Prep Program",
                Location = "ONLINE",
                StartDate = new DateTime(2020, 7, 1),
                EndDate = new DateTime(2020, 12, 31)
            };
        }
    }
}
