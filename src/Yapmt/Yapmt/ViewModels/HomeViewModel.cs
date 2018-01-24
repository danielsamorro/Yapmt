using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yapmt.Models;

namespace Yapmt.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Projects = new List<Project>();
        }

        public List<Project> Projects { get; set; }
    }
}