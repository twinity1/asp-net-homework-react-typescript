using System.Linq;
using System.Threading.Tasks;
using AspHomework2.Controllers.API.DTOs;
using AspHomework2.Extensions;
using AspHomework2.Hubs;
using AspHomework2.Persistence.Repositories;
using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AspHomework2.Controllers.API
{
    [Route("api/branches")]
    public class BranchesController : Controller
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;
        private readonly IHubContext<JobApplicationHub> _jobApplicationHubContext;

        public BranchesController(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var branches = _branchRepository.FindAll();

            var mapped = branches.Select(x => _mapper.Map<BranchDto>(x)).ToList();
            
            return Ok(mapped);
        }
    }
}