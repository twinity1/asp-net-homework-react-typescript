using AspHomework2.Controllers.API.DTOs;
using AspHomework2.Persistence.Entities;
using AutoMapper;

namespace ASPHomework.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<JobPosition, JobPositionDto>();
            CreateMap<Branch, BranchDto>();
        }
    }
}