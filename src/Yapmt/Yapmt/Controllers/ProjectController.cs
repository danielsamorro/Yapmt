using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yapmt.Services;
using Yapmt.ViewModels;

namespace Yapmt.Controllers
{
    public class ProjectController : Controller
    {
        private ProjectService _projectService;

        public ProjectController()
        {
            _projectService = new ProjectService();
        }

        // GET: Project
        public ActionResult Index(int id)
        {   
            var viewModel = new ProjectViewModel();

            viewModel.Project = _projectService.GetProject(id);

            return View(viewModel);
        }
    }
}