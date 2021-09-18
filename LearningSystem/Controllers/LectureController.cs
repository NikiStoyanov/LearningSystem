using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningSystem.Data;

namespace LearningSystem.Controllers
{
    public class LectureController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LectureController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult All(int id)
        {
            var lectures = this._db
                .Lectures
                .Where(c => c.CourseId == id)
                .OrderBy(p => p.Id)
                .ToList();

            var courseName = this._db.Courses.FirstOrDefault(p => p.Id == id)?.Name;

            this.ViewBag.Lectures = lectures;
            this.ViewBag.CourseName = courseName;

            return View();
        }

        public IActionResult Overview(int id)
        {
            var lecture = this._db
                .Lectures
                .FirstOrDefault(c => c.Id == id);

            var lectureName = this._db.Lectures.FirstOrDefault(p => p.Id == id)?.Name;

            this.ViewBag.Lecture = lecture;
            this.ViewBag.LectureName = lectureName;

            return View();
        }
    }
}
