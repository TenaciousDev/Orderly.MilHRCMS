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
    public class HousingController : Controller
    {
        // GET: Housing
        public ActionResult Index()
        {
            var service = CreateHousingService();
            var model = service.GetHousing();
            return View(model);
        }
        //GET: Housing/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Housing/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HousingCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateHousingService();
            if (service.CreateHousing(model))
            {
                TempData["Save Result"] = "Record created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Unable to create record.");
            return View(model);
        }
        //GET: Housing/Details/id
        public ActionResult Details(int id)
        {
            var svc = CreateHousingService();
            var model = svc.GetHousingByPersonnelId(id);
            return View(model);
        }
        //GET: Housing/Edit/id
        public ActionResult Edit(int id)
        {
            var svc = CreateHousingService();
            var detail = svc.GetHousingByPersonnelId(id);
            var model =
                new HousingEdit
                {
                    Id = detail.Id,
                    PersonnelId = detail.PersonnelId,
                    Personnel = detail.Personnel,
                    Address = detail.Address,
                    Room = detail.Room,
                    //CreatedBy = detail.CreatedBy,
                    //CreatedUtc = detail.CreatedUtc,
                    ModifiedLast = detail.ModifiedLast,
                    ModifiedUtc = detail.ModifiedUtc
                };
            return View(model);
        }
        //POST: Housing/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, HousingEdit model)
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
            var svc = CreateHousingService();
            if (svc.UpdateHousing(model))
            {
                TempData["SaveResult"] = "Record updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        private HousingService CreateHousingService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new HousingService(userId);
            return service;
        }
    }
}