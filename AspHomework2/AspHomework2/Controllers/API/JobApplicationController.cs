using System.Threading.Tasks;
using AspHomework2.Controllers.API.DTOs;
using AspHomework2.Extensions;
using AspHomework2.Hubs;
using AspHomework2.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AspHomework2.Controllers.API
{
    [Route("api/jobApplication")]
    public class JobApplicationController : Controller
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IHubContext<JobApplicationHub> _jobApplicationHubContext;

        public JobApplicationController(IBranchRepository branchRepository, IHubContext<JobApplicationHub> jobApplicationHubContext)
        {
            _branchRepository = branchRepository;
            _jobApplicationHubContext = jobApplicationHubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] JobApplicationDto jobApplicationDto)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(new ModelStateErrorList(ModelState).AsList());
            }
            
            _branchRepository.Save(jobApplicationDto);

            await _jobApplicationHubContext.Clients.All.SendCoreAsync("Refresh", new object[0]);
            
            return Ok(new
            {
                Success = true
            });
        }

    }
}