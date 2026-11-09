using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYAcademy_PortfolioProject.Context;

namespace MYAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultProjectsComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultProjectsComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Projects.Include(x=>x.Category).ToList();
            return View(values);
        }
    }
}
