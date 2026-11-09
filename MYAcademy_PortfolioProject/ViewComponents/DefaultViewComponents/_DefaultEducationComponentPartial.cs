using Microsoft.AspNetCore.Mvc;
using MYAcademy_PortfolioProject.Context;

namespace MYAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultEducationComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultEducationComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Educations
    .ToList()
    .OrderByDescending(x => DateTime.ParseExact(x.Duration, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture))
    .ToList();
            return View(values);
        }
    }
}
