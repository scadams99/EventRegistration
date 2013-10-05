using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventRegistration.Models.Domain;
using EventRegistration.Models.Domain.Repository;

namespace EventRegistration.Controllers
{
    public class RegistrationController : Controller
    {
        private IRepository repository; // field for repository

        // dependency resolver
        public RegistrationController(IRepository repo)
        {
            repository = repo;
        }

        public ActionResult Index()
        {
            ViewBag.Competitions = repository.Competitions; // Easy because of the use of Entity Framework.
           
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem
            {
                Text = "Swimming",
                Value = "1"
            });
            items.Add(new SelectListItem
            {
                Text = "Cycling",
                Value = "2",
                Selected = true
            });
            items.Add(new SelectListItem
            {
                Text = "Running",
                Value = "3"
            });
            ViewBag.ADropdown = items;
            return View();
        }

        [HttpPost]
        public ActionResult Index(Registration registration)
        {
            repository.SaveRegistration(registration);
            return View("RegistrationComplete", registration);
        }

        public ActionResult List()
        {
            ViewBag.Time = DateTime.Now;
            return View(repository.Registrations);
        }
    }
}
