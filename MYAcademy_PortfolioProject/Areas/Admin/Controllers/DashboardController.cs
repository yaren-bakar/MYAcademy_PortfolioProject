using Microsoft.AspNetCore.Mvc;
using MYAcademy_PortfolioProject.Context;

namespace MYAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        private readonly PortfolioContext _context;

        public DashboardController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.MessageCount = _context.Messages.Count();
            ViewBag.MessageReadByTrueCount = _context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.MessageReadByFalseCount = _context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.Messages = _context.Messages.OrderByDescending(x => x.SendDate).Take(5).ToList();
            ViewBag.Projects = _context.Projects.OrderByDescending(x => x.ProjectID).Take(5).ToList();
            ViewBag.ProjectCount = _context.Projects.Count();

            var about = _context.Abouts.FirstOrDefault();

            int filledFields = 0;
            int totalFields = 6;

            if (about != null)
            {
                if (!string.IsNullOrWhiteSpace(about.NameSurname))
                    filledFields++;

                if (!string.IsNullOrWhiteSpace(about.JobTitle))
                    filledFields++;

                if (!string.IsNullOrWhiteSpace(about.Location))
                    filledFields++;

                if (!string.IsNullOrWhiteSpace(about.Description))
                    filledFields++;

                if (!string.IsNullOrWhiteSpace(about.Expert))
                    filledFields++;

                if (!string.IsNullOrWhiteSpace(about.Email))
                    filledFields++;
            }

            ViewBag.ProfileCompletion = (int)Math.Round(
                filledFields * 100.0 / totalFields
            );
            return View();
        }
    }
}
