using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yapmt.Services;
using Yapmt.ViewModels;

namespace Yapmt.Controllers
{
    public class HomeController : Controller
    {
        private ProjectService _projectService;

        public HomeController()
        {
            _projectService = new ProjectService();
        }

        public ActionResult Index()
        {
            var viewModel = new HomeViewModel();

            viewModel.Projects = _projectService.GetProjects();

            return View(viewModel);
        }
    }
}