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
    public class SquadController : Controller
    {
        // GET: Squad
        public ActionResult Index()
        {
            var service = CreateSquadService();
            var model = service.GetSquads();
            return View(model);
        }
        //GET: Squad/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Squad/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SquadCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateSquadService();
            if (service.CreateSquad(model))
            {
                TempData["Save Result"] = "Record created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Unable to create record.");
            return View(model);
        }
        //GET: Squad/Details/id
        public ActionResult Details(int id)
        {
            var svc = CreateSquadService();
            var model = svc.GetSquadById(id);
            return View(model);
        }
        //GET: Squad/Edit/id
        public ActionResult Edit(int id)
        {
            var svc = CreateSquadService();
            var detail = svc.GetSquadById(id);
            var model =
                new SquadEdit
                {
                    Id = detail.Id,
                    Name = detail.Name,
                    Familiar = detail.Familiar,
                    Assigned = detail.Assigned,
                    Teams = detail.Teams
                };
            return View(model);
        }
        //POST: Squad/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SquadEdit model)
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
            var svc = CreateSquadService();
            if (svc.UpdateSquad(model))
            {
                TempData["SaveResult"] = "Record updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        private SquadService CreateSquadService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new SquadService(userId);
            return service;
        }

    }
}