using AspHomework2.Models;
using AspHomework2.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspHomework2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobApplicationRepository _jobApplicationRepository;

        public HomeController(IJobApplicationRepository jobApplicationRepository)
        {
            _jobApplicationRepository = jobApplicationRepository;
        }
        
        public IActionResult Index()
        {
            return View(CreateViewModel());
        }

        public IActionResult RedrawList()
        {
            return View("_JobApplications", CreateViewModel());
        }

        private HomeViewModel CreateViewModel()
        {
            var viewModel = new HomeViewModel();

            viewModel.JobApplications = _jobApplicationRepository.FindAllForDashboard();
            viewModel.ItemsCount = _jobApplicationRepository.CountAllForDashboard();

            return viewModel;
        }
    }
}