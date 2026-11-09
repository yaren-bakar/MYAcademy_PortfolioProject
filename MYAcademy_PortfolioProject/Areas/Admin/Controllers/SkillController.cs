using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MYAcademy_PortfolioProject.Context;
using MYAcademy_PortfolioProject.Entities;

namespace MYAcademy_PortfolioProject.Areas.Admin.Controllers
{ 
[Area("Admin")]
    public class SkillController : Controller
    {
    private readonly PortfolioContext _context;

    public SkillController(PortfolioContext context)
    {
        _context = context;
    }

    public IActionResult SkillList()
        {
        var value = _context.Skills.Include(x => x.SkillCategory).ToList();
            return View(value);
        }

        public IActionResult CreateSkill()
        {
            var categories = _context.SkillCategories.ToList();
            ViewBag.CategoryList = new SelectList(categories, "SkillCategoryID", "CategoryName");
            return View();
        }

        [HttpPost]

        public IActionResult CreateSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = _context.Skills.Find(id);
            _context.Skills.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = _context.Skills.Find(id);
            var categories = _context.SkillCategories.ToList();
            ViewBag.CategoryList = new SelectList(categories, "SkillCategoryID", "CategoryName");
            return View(value);
        }

        [HttpPost]

        public IActionResult UpdateSkill(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }

    }
}
