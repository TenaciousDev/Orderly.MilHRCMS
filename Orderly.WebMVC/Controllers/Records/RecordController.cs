using Microsoft.AspNet.Identity;
using Orderly.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orderly.WebMVC.Controllers
{
    [Authorize]
    public class RecordController : Controller
    {
        // GET: Record
        public ActionResult Index()
        {
            var service = CreateRecordService();
            var model = service.GetRecords();
            return View(model);
        }
        //GET: Record/Detail/id
        public ActionResult Details(int id)
        {
            var svc = CreateRecordService();
            var model = svc.GetRecordByPersonnelId(id);
            return View(model);
        }
        private RecordService CreateRecordService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RecordService(userId);
            return service;
        }
    }
}