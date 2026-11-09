using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MYAcademy_PortfolioProject.Context;
using MYAcademy_PortfolioProject.Entities;

namespace MYAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectsController : Controller
    {
        private readonly PortfolioContext _context;

        public ProjectsController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult ProjectList()
        {
            var values = _context.Projects.Include(x => x.Category).ToList();
            return View(values);
        }

        [HttpGet]

        public IActionResult CreateProject()
        {
            var categories = _context.Categories.ToList();
            ViewBag.CategoryList = new SelectList(categories, "CategoryID", "CategoryName");

            return View();
        }

        [HttpPost]

        public IActionResult CreateProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return RedirectToAction("ProjectList");
        }

        public IActionResult DeleteProject(int id)
        {
            var value = _context.Projects.Find(id);
            _context.Projects.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ProjectList");
        }

        public IActionResult UpdateProject(int id)
        {
            var value = _context.Projects.Find(id);
            var categories = _context.Categories.ToList();
            ViewBag.CategoryList = new SelectList(categories, "CategoryID", "CategoryName", value.CategoryID);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProject(Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}
