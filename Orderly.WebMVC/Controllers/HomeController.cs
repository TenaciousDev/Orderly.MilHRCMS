using Orderly.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orderly.WebMVC.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                using (var ctx = new ApplicationDbContext())
            {
                var tracking =
                    ctx.PersonnelDbSet.Count();
                TempData["Tracking Message"] =
                    $"Currently tracking {tracking} records.";
                return View();
            };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}