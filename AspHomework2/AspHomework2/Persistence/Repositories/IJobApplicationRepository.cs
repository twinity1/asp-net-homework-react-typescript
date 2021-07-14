using System.Collections.Generic;
using AspHomework2.Models;
using AspHomework2.Persistence.Entities;

namespace AspHomework2.Persistence.Repositories
{
    public interface IJobApplicationRepository
    {
        public List<JobApplication> FindAllForDashboard();
        
        public List<JobApplication> FindAllUndone();

        public JobApplication? FistOrNullById(int id);

        public int CountAllForDashboard();
        
        public int CountAllUndone();

        public void ConfirmJobApplication(JobApplication jobApplication, JobApplicationAnswerViewModel jobApplicationViewModel);
    }
}