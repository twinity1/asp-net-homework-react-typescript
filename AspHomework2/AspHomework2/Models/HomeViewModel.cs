using System.Collections.Generic;
using AspHomework2.Persistence.Entities;

namespace AspHomework2.Models
{
    public class HomeViewModel
    {
        public int ItemsCount { get; set; }
        
        public List<JobApplication> JobApplications { get; set; } 
    }
}