using Microsoft.AspNetCore.Mvc;
using MYAcademy_PortfolioProject.Context;
using MYAcademy_PortfolioProject.Entities;

namespace MYAcademy_PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CertificateController : Controller
    {
        private readonly PortfolioContext _context;

        public CertificateController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult CertificateList()
        {
            var values = _context.Certificates.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCertificate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCertificate(Certificate certificate)
        {
            if (!ModelState.IsValid)
            {
                return View(certificate);
            }

            _context.Add(certificate);
            _context.SaveChanges();
            return RedirectToAction("CertificateList");
        }

        public IActionResult DeleteCertificate(int id)
        {
            var value = _context.Certificates.Find(id);

            if (value == null)
                return NotFound();

            _context.Remove(value);
            _context.SaveChanges();

            return RedirectToAction("CertificateList");
        }

        [HttpGet]
        public IActionResult UpdateCertificate(int id)
        {
            var value = _context.Certificates.Find(id);

            if (value == null)
                return NotFound();

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCertificate(Certificate certificate)
        {
            if (!ModelState.IsValid)
            {
                return View(certificate);
            }

            _context.Update(certificate);
            _context.SaveChanges();

            return RedirectToAction("CertificateList");
        }
    }
}
