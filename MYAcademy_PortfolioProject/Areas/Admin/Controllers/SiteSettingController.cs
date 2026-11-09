using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SiteSettingController : Controller
    {
        public IActionResult SiteSettingList()
        {
            return View();
        }
    }
}
