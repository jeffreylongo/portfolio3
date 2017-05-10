using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace portfolio3.Models
{
    public class Project 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string gitUrl { get; set; }
        public string liveUrl { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
