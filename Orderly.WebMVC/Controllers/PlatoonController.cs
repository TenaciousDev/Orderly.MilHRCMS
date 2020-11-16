using Microsoft.AspNet.Identity;
using Orderly.Models;
using Orderly.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orderly.WebMVC.Controllers
{
    [Authorize]
    public class PlatoonController : Controller
    {
        // GET: Platoon
        public ActionResult Index()
        {
            var service = CreatePlatoonService();
            var model = service.GetPlatoons();
            return View();
        }
        //GET: Platoon/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Platoon/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlatoonCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreatePlatoonService();
            if (service.CreatePlatoon(model))
            {
                TempData["Save Result"] = "Record created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Unable to create record.");
            return View(model);
        }
        //GET: Platoon/Details/id
        public ActionResult Details(int id)
        {
            var svc = CreatePlatoonService();
            var model = svc.GetPlatoonById(id);
            return View(model);
        }
        //GET: Platoon/Edit/id
        public ActionResult Edit(int id)
        {
            var svc = CreatePlatoonService();
            var detail = svc.GetPlatoonById(id);
            var model =
                new PlatoonEdit
                {
                    Id = detail.Id,
                    Name = detail.Name,
                    Familiar = detail.Familiar,
                    Assigned = detail.Assigned,
                    Squads = detail.Squads,
                    Teams = detail.Teams
                };
            return View(model);
        }
        //POST: Platoon/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PlatoonEdit model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.Id != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var svc = CreatePlatoonService();
            if (svc.UpdatePlatoon(model))
            {
                TempData["SaveResult"] = "Record updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        private PlatoonService CreatePlatoonService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PlatoonService(userId);
            return service;
        }

    }
}