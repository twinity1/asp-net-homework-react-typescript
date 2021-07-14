using System;
using System.Collections.Generic;
using AspHomework2.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASPHomework.Persistence
{
    public class TestDataGenerator
    {
        public void Generate(ModelBuilder modelBuilder)
        {
            var branches = GetBranches();
            var jobPositions = GetJobPositions();
            
            
            modelBuilder.Entity<Branch>().HasData(branches);
            modelBuilder.Entity<JobPosition>().HasData(jobPositions);
        }

        public static JobPosition[] GetJobPositions()
        {
            return new[]
            {
                new JobPosition
                {
                    Id = 1,
                    Title = "Angular junior",
                    BranchId = 1
                },
                
                new JobPosition
                {
                    Id = 2,
                    Title = "PHP senior",
                    BranchId = 1
                },
                new JobPosition
                {
                    Id = 3,
                    Title = "Ruby medior",
                    BranchId = 2
                },
                new JobPosition
                {
                    Id = 4,
                    Title = "HR",
                    BranchId = 2
                },
                new JobPosition
                {
                    Id = 5,
                    Title = "Java senior",
                    BranchId = 3
                },
            };
        }
        public Branch[] GetBranches()
        {
            return new[]
            {
                new Branch
                {
                    Id = 1,
                    Title = "Praha"
                },
                new Branch
                {
                    Id = 2,
                    Title = "Brno"
                },
                new Branch
                {
                    Id = 3,
                    Title = "Ostrava"
                },
            };
        }
    }
}