using CourseRegistration1.Models;
using CourseRegistration1.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistration1.Controllers
{
    public class InstructorsController : Controller
    {
        private static MockInstructorsRepo _instructorsRepo = new MockInstructorsRepo();

        // GET: InstructorsController
        public ActionResult Index()
        {
            return View(_instructorsRepo.GetAll());
        }

        // GET: InstructorsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InstructorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InstructorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instructor collection)
        {
            try
            {
                _instructorsRepo.Create(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InstructorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InstructorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Instructor collection)
        {
            try
            {
                _instructorsRepo.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InstructorsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InstructorsController/Delete/5
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
