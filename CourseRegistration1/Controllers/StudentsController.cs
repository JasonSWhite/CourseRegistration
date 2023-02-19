using CourseRegistration1.Models;
using CourseRegistration1.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseRegistration1.Controllers
{
    public class StudentsController : Controller
    {
        private static MockStudentsRepo _studentsRepo = new MockStudentsRepo();
        private static MockCoursesRepo _coursesRepo = new MockCoursesRepo();

        // GET: StudentsController
        public ActionResult Index()
        {
           
            return View(_studentsRepo.GetAll());
        }

        public IEnumerable<string> GetStudentsByCourseName(string sName)
        {
            var res = _studentsRepo.GetAll()
                .Where(s => s.C_name == sName)
                .Select(s => s.C_name);
            if (res == null)
            {
                return new List<string> { "No Students Enrolled" };
            }
            return res;
        }
        // GET: StudentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentsController/Create
        public ActionResult Create()
        {
            ViewBag.Courses = new SelectList(_coursesRepo.GetAll(), "C_name");
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student collection)
        {
            try
            {
                _studentsRepo.Create(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student collection)
        {
            try
            {
                _studentsRepo.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
