using System.Collections.Generic;
using System.Linq;
using AspHomework2.Controllers.API;
using AspHomework2.Controllers.API.DTOs;
using AspHomework2.Persistence.Entities;
using AspHomework2.Persistence.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AspHomework2Tests
{
    [TestClass]
    public class BranchesApiControllerUnitTest
    {
        [TestMethod]
        public void TestGet()
        {          
            var branches = new List<Branch>
            {
                new Branch
                {
                    Id = 1,
                    Title = "Pobočka 1",
                    JobPositions = new List<JobPosition>
                    {
                        new JobPosition
                        {
                            Id = 1,
                            Title = "Pozice 1"
                        },
                        new JobPosition
                        {
                            Id = 2,
                            Title = "Pozice 2"
                        }
                    }
                },
                new Branch
                {
                    Id = 2,
                    Title = "Pobočka 2",
                    JobPositions = new List<JobPosition>
                    {
                        new JobPosition
                        {
                            Id = 3,
                            Title = "Pozice 3"
                        }
                    }
                }
            };
            
            var mock = new Mock<IBranchRepository>();
            mock.Setup(dr => dr.FindAll()).Returns(branches);
            
            var mockMapper = new Mock<IMapper>();
            mockMapper.Setup(mm => mm.Map<BranchDto>(It.IsAny<Branch>())).Returns((Branch x) =>
            {
                return new BranchDto()
                {
                    Title = x.Title,
                    JobPositions = x.JobPositions.Select(jp => new JobPositionDto()
                    {
                        Title = jp.Title
                    }).ToList()
                };
            });

            var controller = new BranchesController(mock.Object, mockMapper.Object);
            
            var actionResult = controller.Get();
            Assert.IsInstanceOfType(actionResult, typeof(OkObjectResult));

            var okObjectResult = actionResult as OkObjectResult;
            
            Assert.IsInstanceOfType(okObjectResult.Value, typeof(List<BranchDto>));
            var value = okObjectResult.Value as List<BranchDto>;

            foreach (var branch in value)
            {
                Assert.IsNotNull(branch);
            }

            Assert.Equals(value.Count(), 1);
        }
    }
}