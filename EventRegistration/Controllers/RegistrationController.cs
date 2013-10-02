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

        // create instance
        /*
        public RegistrationController()
        {
            repository = new DummyRepository(); // not the way to do this. it creates a dependencey and opens up the implementation. Fixed later.
        }
         */
        // dependency resolver
        public RegistrationController(IRepository repo)
        {
            repository = repo;
        }

        public ActionResult Index()
        {
            ViewBag.Competitions = repository.Competitions.Select(e => e.Name);
            return View();
        }

        [HttpPost]
        //public ActionResult Index(string name, string homecity, string age, string competition)
        public ActionResult Index(Registration registration, string competition)    // this uses model binding
        {
            /*
            Registration registration = new Registration
            {
                Name = name,
                HomeCity = homecity,
                Age = int.Parse(age),
                Competition = repository.Competitions
                                        .Where(e => e.Name == competition)
                                        .FirstOrDefault()
            };
            */
            registration.Competition = repository.Competitions.Where(e => e.Name == competition).FirstOrDefault();

            repository.SaveRegistration(registration);  // defined in the dummy repository.cs
            return View("RegistrationComplete", registration);  // Name of the view to render and the data to display
        }
    }
}
