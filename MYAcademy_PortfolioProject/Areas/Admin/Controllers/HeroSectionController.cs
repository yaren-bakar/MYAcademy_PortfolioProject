using Microsoft.AspNetCore.Mvc;
using MYAcademy_PortfolioProject.Context;
using MYAcademy_PortfolioProject.Entities;

namespace MYAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class HeroSectionController : Controller
    {
        private readonly PortfolioContext _context;
        private readonly IWebHostEnvironment _environment;

        public HeroSectionController(
            PortfolioContext context,
            IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpGet]
        public IActionResult HeroSectionList()
        {
            var value = _context.HeroSections.FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult HeroSectionList(HeroSection model, IFormFile imageFile)
        {
            var value = _context.HeroSections.Find(model.HeroSectionID);
            if (value == null) return NotFound();
            value.Title = model.Title;
            value.SubTitle = model.SubTitle;
            value.Description = model.Description;

            if (imageFile != null && imageFile.Length > 0)
            {
                var allowed = new[] { ".jpg", ".jpeg", ".png", ".webp" };
                var extension = Path.GetExtension(imageFile.FileName).ToLowerInvariant();

                if (!allowed.Contains(extension) || imageFile.Length > 2 * 1024 * 1024)
                {
                    TempData["Error"] = "Sadece jpg, png veya webp yükleyebilirsiniz (en fazla 2 MB).";
                    return RedirectToAction("Index");
                }

                var folder = Path.Combine(_environment.WebRootPath, "images");
                Directory.CreateDirectory(folder);

                var fileName = Guid.NewGuid() + extension;
                var fullPath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                value.ImageUrl = "/images/" + fileName;
            }

            _context.SaveChanges();
            return RedirectToAction("HeroSectionList");
        }

    }
}
