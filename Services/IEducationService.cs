using System;
using System.Collections.Generic;
using ProjectApp.Models;

namespace ProjectApp.Services
{
    public interface IEducationService
    {
        List<EducationEntry> GetAllEntries();
        EducationEntry GetMostRecentEntry();
    }
}
