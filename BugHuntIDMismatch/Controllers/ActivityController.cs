using BugHuntIDMismatch.Repositories;
using BugHuntIDMismatch.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugHuntIDMismatch.Controllers
{
    public class ActivityController : Controller
    {
        [HttpGet]
        [Route("~/")]
        [Route("report/activities/{id}")]
        public ActionResult Index(long id = 11)
        {
            ActivityRepository repo = new ActivityRepository();

            ActivityIndexVM model = new ActivityIndexVM()
            {
                Activities = repo.GetForReport(id)
            };

            return View(model);
        }

        [HttpGet]
        [Route("report/activities/edit/{id}")]
        public ActionResult Edit(long id)
        {
            ActivityRepository repo = new ActivityRepository();
            var activity = repo.GetByID(id);

            ActivityEditVM model = new ActivityEditVM()
            {
                ID = activity.ReportID,
                ActivityID = activity.ID,
                Description = activity.Description,
                TargetDate = activity.TargetDate
            };

            return View(model);
        }

        [HttpPost]
        [Route("report/activities/edit/post")]
        public ActionResult EditPost(ActivityEditVM model)
        {
            var id = model.ID; //Put a breakpoint here to see the bug.

            return RedirectToAction("Index", new { id = model.ID });
        }
    }
}