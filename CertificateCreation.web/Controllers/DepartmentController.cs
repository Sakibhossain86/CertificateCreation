using CertificateCreation.Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;

namespace CertificateCreation.web.Controllers
{
    public class DepartmentController : Controller
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
        public IActionResult Create(Department model)
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
