using System.Collections.Generic;
using AspHomework2.Persistence.Entities;

namespace AspHomework2.Models
{
    public class JobApplicationIndexViewModel
    {
        public int ItemsCount { get; set; }
        
        public List<JobApplication> JobApplications { get; set; } 
    }
}