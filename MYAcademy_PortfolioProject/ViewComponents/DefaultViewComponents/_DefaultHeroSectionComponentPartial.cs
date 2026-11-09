using Microsoft.AspNetCore.Mvc;
using MYAcademy_PortfolioProject.Context;

namespace MYAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeroSectionComponentPartial  :ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultHeroSectionComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value = _context.HeroSections.FirstOrDefault();
            ViewBag.V1 = value.Title;
            ViewBag.V2 = value.SubTitle;
            ViewBag.V3= value.Description;
            ViewBag.V4 = value.ImageUrl;

            ViewBag.SocialMedias = _context.SocialMedias.ToList();
            return View();
        }
    }
}
