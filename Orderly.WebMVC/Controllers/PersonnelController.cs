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
    public class PersonnelController : Controller
    {
        // GET: Personnel
        public ActionResult Index()
        {
            var service = CreatePersonnelService();
            var model = service.GetPersonnel();
            return View(model);
        }
        //GET: Personnel/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Personnel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonnelCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreatePersonnelService();
            if (service.CreatePersonnel(model))
            {
                TempData["Save Result"] = "Record created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Unable to create record.");
            return View(model);
        }
        //GET: Personnel/Details/id
        public ActionResult Details(int id)
        {
            var svc = CreatePersonnelService();
            var model = svc.GetPersonnelById(id);
            return View(model);
        }
        //GET: Personnel/Edit/id
        public ActionResult Edit(int id)
        {
            var svc = CreatePersonnelService();
            var detail = svc.GetPersonnelById(id);
            var model =
                new PersonnelEdit
                {
                    PersonnelId = detail.PersonnelId,
                    Rank = detail.Rank,
                    FirstName = detail.FirstName,
                    LastName = detail.LastName,
                    MiddleName = detail.MiddleName,
                    Sex = detail.Sex,
                    SSN = detail.SSN,
                    DOD = detail.DOD,
                    DOB = detail.DOB,
                    MaritalStatus = detail.MaritalStatus,
                    ModifiedLast = detail.ModifiedLast,
                    ModifiedUtc = detail.ModifiedUtc
                };
            return View(model);
        }
        //POST: Personnel/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonnelEdit model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.PersonnelId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var svc = CreatePersonnelService();
            if (svc.UpdatePersonnel(model))
            {
                TempData["SaveResult"] = "Record updated.";
                return RedirectToAction("Details", new { id = model.PersonnelId });
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        private PersonnelService CreatePersonnelService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PersonnelService(userId);
            return service;
        }
    }
}