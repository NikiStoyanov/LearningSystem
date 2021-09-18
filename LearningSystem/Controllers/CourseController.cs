using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningSystem.Data;

namespace LearningSystem.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CourseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult All(int id)
        {
            var courses = this._db
                .Courses
                .Where(c => c.PathId == id)
                .OrderBy(p => p.Id)
                .ToList();

            var pathName = this._db.Paths.FirstOrDefault(p => p.Id == id)?.Title;

            this.ViewBag.Courses = courses;
            this.ViewBag.PathName = pathName;

            return View();
        }
    }
}
