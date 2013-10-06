using System.Web.Mvc;
using EventRegistration.Models.View;
namespace EventRegistration.Controllers
{
    public class CompetitionController : Controller
    {
        public ActionResult Summary()
        {
            CompetitionSummary summary = new CompetitionSummary
            {
                Name = "Mass Mangler",
                City = "Boston",
                Date = new System.DateTime(2013, 1, 20),
                Approved = true,
                Start = StartTime.Evening
            };
            return View(summary);
        }
    }
}
