using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Data.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string TrainerName { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

        public int PathId { get; set; }

        public virtual Path Path { get; set; }

        public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
    }
}
