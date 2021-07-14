using System;
using System.Collections.Generic;
using System.Linq;
using AspHomework2.Controllers.API.DTOs;
using AspHomework2.FileSystem;
using AspHomework2.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace AspHomework2.Persistence.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly AppDatabaseContext _appDatabaseContext;
        private readonly FileWriter _fileWriter;

        public BranchRepository(AppDatabaseContext appDatabaseContext, FileWriter fileWriter)
        {
            _appDatabaseContext = appDatabaseContext;
            _fileWriter = fileWriter;
        }
        
        public List<Branch> FindAll()
        {
            return _appDatabaseContext.Branches.ToList();
        }

        public void Save(JobApplicationDto jobApplicationDto)
        {
            var entity = new JobApplication();

            var jobPosition = _appDatabaseContext.JobPositions.First(x => x.Id == jobApplicationDto.JobPositionId);

            var base64 = jobApplicationDto.CvBase64.Substring(jobApplicationDto.CvBase64.LastIndexOf(',') + 1);
            
            entity.Content = jobApplicationDto.Content;
            entity.Email = jobApplicationDto.Email;
            entity.Phone = jobApplicationDto.Phone;
            entity.CvFilePath = _fileWriter.SaveBase64File(jobApplicationDto.CvFileName, base64);
            entity.JobPositionId = jobPosition.Id;
            entity.JobPosition = jobPosition;

            _appDatabaseContext.JobApplications.Add(entity);
            _appDatabaseContext.SaveChanges();
        }
    }
}