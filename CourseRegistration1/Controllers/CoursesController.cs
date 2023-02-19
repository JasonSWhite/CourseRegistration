using CourseRegistration1.Models;
using CourseRegistration1.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseRegistration1.Controllers
{
    public class CoursesController : Controller
    {

        private readonly MockCoursesRepo _coursesRepo = new MockCoursesRepo();
        // GET: Courses
        public ActionResult Index()
        {
            return View(_coursesRepo.GetAll());
        }

        // GET: Courses/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            ViewBag.Courses = new SelectList(_coursesRepo.GetAll());
            return View();
        }

        // POST: Courses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course collection)
        {
            try
            {
                _coursesRepo.Create(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int id)
        {
            var courseToEdit = _coursesRepo.GetById(id);
            return View(courseToEdit);
        }

        // POST: Courses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course collection)
        {
            try
            {
                _coursesRepo.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Courses/Delete/5
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
