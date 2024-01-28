using CertificateCreation.Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CertificateCreation.web.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
                return View();
        }
    }
}
