using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yapmt.Models;

namespace Yapmt.Services
{
    public class ProjectService
    {
        private YapmtContext _dbContext;

        public ProjectService()
        {
            _dbContext = new YapmtContext();
        }

        public void AddProject(Project project)
        {
            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
        }

        public int DeleteProject(int projectId)
        {
            var project = _dbContext.Projects.Include("Tasks").Where(p => p.Id == projectId).SingleOrDefault();

            _dbContext.Projects.Remove(project);
            return _dbContext.SaveChanges();
        }

        public List<Project> GetProjects()
        {
            return _dbContext.Projects.ToList();
        }

        public Project GetProject(int projectId)
        {
            return _dbContext.Projects.Where(p => p.Id == projectId).SingleOrDefault();
        }

        public int AddTask(Task task, int projectId)
        {
            var project = _dbContext.Projects.Where(p => p.Id == projectId).SingleOrDefault();
            project.Tasks.Add(task);
            return _dbContext.SaveChanges();
        }

        public void DeleteTask(int taskId)
        {
            _dbContext.Tasks.Remove(_dbContext.Tasks.Where(t => t.Id == taskId).SingleOrDefault());
        }

        public Task GetTask(int taskId)
        {
            return _dbContext.Tasks.Where(t => t.Id == taskId).SingleOrDefault();
        }

        public List<Task> GetTasks()
        {
            return _dbContext.Tasks.ToList();
        }

        public int ChangeTaskStatus(int taskId)
        {
            var task = _dbContext.Tasks.Where(t => t.Id == taskId).SingleOrDefault();
            task.Completed = !task.Completed;
            return _dbContext.SaveChanges();
        }

    }
}