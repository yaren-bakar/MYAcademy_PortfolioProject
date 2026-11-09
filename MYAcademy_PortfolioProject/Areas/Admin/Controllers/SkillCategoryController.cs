using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MYAcademy_PortfolioProject.Context;
using MYAcademy_PortfolioProject.Entities;

namespace MYAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillCategoryController : Controller
    {
        private readonly PortfolioContext _context;

        public SkillCategoryController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult SkillCategoryList()
        {
            var value = _context.SkillCategories.ToList();
            return View(value);
        }

        public IActionResult CreateSkillCategory()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateSkillCategory(SkillCategory skill)
        {
            _context.SkillCategories.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillCategoryList");
        }

        public IActionResult DeleteSkillCategory(int id)
        {
            var value = _context.SkillCategories.Find(id);
            _context.SkillCategories.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("SkillCategoryList");
        }
        [HttpGet]
        public IActionResult UpdateSkillCategory(int id)
        {
            var value = _context.SkillCategories.Find(id);
            return View(value);
        }

        [HttpPost]

        public IActionResult UpdateSkillCategory(SkillCategory skill)
        {
            _context.SkillCategories.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillCategoryList");
        }

    }
}
