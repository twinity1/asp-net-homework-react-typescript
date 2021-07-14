using System;
using System.Collections.Generic;
using System.Linq;
using AspHomework2.Models;
using AspHomework2.Persistence.Entities;

namespace AspHomework2.Persistence.Repositories
{
    public class JobApplicationRepository : IJobApplicationRepository
    {
        private readonly AppDatabaseContext _appDatabaseContext;

        public JobApplicationRepository(AppDatabaseContext appDatabaseContext)
        {
            _appDatabaseContext = appDatabaseContext;
        }
        
        public List<JobApplication> FindAllForDashboard()
        {
            return BaseQueryWithUndoneApplication().Take(10).ToList();
        }

        public List<JobApplication> FindAllUndone()
        {
            return BaseQueryWithUndoneApplication().ToList();
        }

        public int CountAllForDashboard()
        {
            return BaseQueryWithUndoneApplication().Count();
        }

        public int CountAllUndone()
        {
            return BaseQueryWithUndoneApplication().Count();
        }

        private IQueryable<JobApplication> BaseQueryWithUndoneApplication()
        {
            return _appDatabaseContext.JobApplications.Where(x => x.Done == false).OrderBy(x => x.Created);
        }

        public JobApplication? FistOrNullById(int id)
        {
            return _appDatabaseContext.JobApplications.FirstOrDefault(x => x.Id == id);
        }

        public void ConfirmJobApplication(JobApplication jobApplication, JobApplicationAnswerViewModel jobApplicationViewModel)
        {
            jobApplication.Answer = jobApplicationViewModel.Answer;
            jobApplication.Done = true;
            jobApplication.Accepted = jobApplicationViewModel.Accepted;

            if (jobApplication.AnswerCreated == null)
            {
                jobApplication.AnswerCreated = DateTime.Now;   
            }

            _appDatabaseContext.JobApplications.Update(jobApplication);
            _appDatabaseContext.SaveChanges();
        }
    }
}