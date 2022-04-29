using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Contentful.Core;
using Microsoft.Extensions.Logging;
using ProjectApp.Models;

namespace ProjectApp.Services
{
    public class ContentfulEducationService : IEducationService
    {
        private ContentfulClient _client;
        public ContentfulEducationService()
        {
            var httpClient = new HttpClient();
            _client = new ContentfulClient(httpClient, "dwKsdh8rYhTGQ1VcLAUz2fYU8XzF_FsD-DBRtuyInwA", "8CPcrfazWE_piqt-gTUPx9YaSxMZZ_BznwMvKVkS4oY", "zl4g8ja5q050");

        }

        public List<EducationEntry> GetAllEntries()
        {
            return _client.GetEntries<EducationEntry>().Result.ToList();
        }

        public EducationEntry GetMostRecentEntry()
        {
            return GetAllEntries().OrderByDescending(employer => employer.StartDate).FirstOrDefault();
        }
    }
}
