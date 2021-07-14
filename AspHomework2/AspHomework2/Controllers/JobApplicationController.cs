using System.Threading.Tasks;
using AspHomework2.Hubs;
using AspHomework2.Models;
using AspHomework2.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AspHomework2.Controllers
{
    public class JobApplicationController : Controller
    {
        private readonly IJobApplicationRepository _jobApplicationRepository;
        private readonly IHubContext<JobApplicationHub> _jobApplicationHubContext;

        public JobApplicationController(IJobApplicationRepository jobApplicationRepository, IHubContext<JobApplicationHub> jobApplicationHubContext)
        {
            _jobApplicationRepository = jobApplicationRepository;
            _jobApplicationHubContext = jobApplicationHubContext;
        }

        [HttpGet]
        public IActionResult Answer(int id)
        {
            var entity = _jobApplicationRepository.FistOrNullById(id);

            if (entity == null)
            {
                return NotFound();
            }
            
            return View(new JobApplicationAnswerViewModel
            {
                JobApplication = entity
            });
        }

        [HttpPost]
        public async Task<IActionResult> Answer(int id, JobApplicationAnswerViewModel viewModel)
        {
            var entity = _jobApplicationRepository.FistOrNullById(id);

            if (entity == null)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid == false)
            {
                return View(viewModel);
            }
            
            _jobApplicationRepository.ConfirmJobApplication(entity, viewModel);
            await _jobApplicationHubContext.Clients.All.SendCoreAsync("Refresh", new object[0]);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var modelView = new JobApplicationIndexViewModel
            {
                ItemsCount = _jobApplicationRepository.CountAllUndone(),
                JobApplications = _jobApplicationRepository.FindAllUndone()
            };

            return View(modelView);
        }
    }
}