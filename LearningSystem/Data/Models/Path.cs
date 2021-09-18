using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Data.Models
{
    public class Path
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
