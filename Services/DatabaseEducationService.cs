using System;
using System.Collections.Generic;
using ProjectApp.Models;

namespace ProjectApp.Services
{
    public class DatabaseEducationService : IEducationService
    {
        public DatabaseEducationService()
        {
        }

        public List<EducationEntry> GetAllEntries()
        {
            throw new NotImplementedException();
        }

        public EducationEntry GetMostRecentEntry()
        {
            throw new NotImplementedException();
        }
    }
}
