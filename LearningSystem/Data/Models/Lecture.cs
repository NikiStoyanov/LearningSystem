using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Data.Models
{
    public class Lecture
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string VideoUrl { get; set; }

        public string ExerciseUrl { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
