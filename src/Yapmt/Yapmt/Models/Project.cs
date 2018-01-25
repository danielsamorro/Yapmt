using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yapmt.Models
{
    public class Project
    {
        public Project()
        {
            Tasks = new List<Task>();
        }
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public virtual List<Task> Tasks { get; set; }
    }
}