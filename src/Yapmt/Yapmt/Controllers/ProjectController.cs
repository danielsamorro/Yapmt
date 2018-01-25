using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yapmt.Models;
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

        public ActionResult Delete(int id)
        {
            var success = _projectService.DeleteProject(id);

            if (success > 0)
                return RedirectToAction("Index", "Home");

            return null;
        }

        public ActionResult CompleteTask(int id)
        {
            var success = _projectService.ChangeTaskStatus(id);

            return Redirect(Request.UrlReferrer.ToString());
        }

        [HttpPost]
        public ActionResult Create(Project project)
        {
            _projectService.AddProject(project);

            return RedirectToAction("Index", "Home");
        }
    }
}