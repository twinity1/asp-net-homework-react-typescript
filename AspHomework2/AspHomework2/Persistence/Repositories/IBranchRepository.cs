using System.Collections.Generic;
using AspHomework2.Controllers.API.DTOs;
using AspHomework2.Persistence.Entities;

namespace AspHomework2.Persistence.Repositories
{
    public interface IBranchRepository
    {
        public List<Branch> FindAll();

        public void Save(JobApplicationDto jobApplicationDto);
    }
}