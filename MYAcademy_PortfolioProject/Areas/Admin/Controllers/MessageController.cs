using Microsoft.AspNetCore.Mvc;
using MYAcademy_PortfolioProject.Context;
using MYAcademy_PortfolioProject.Entities;

namespace MYAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly PortfolioContext _context;

        public MessageController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult MessageList(string search)
        {
            var values = _context.Messages.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                values = values.Where(x =>
                    x.NameSurname.Contains(search) ||
                    x.Email.Contains(search) ||
                    x.Subject.Contains(search));
            }

            return View(values.ToList());
        }


        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        [HttpPost]
        public IActionResult MarkAsRead(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null && !message.IsRead)
            {
                message.IsRead = true;
                _context.SaveChanges();
            }
            return RedirectToAction("MessageList");
        }
    }
}
