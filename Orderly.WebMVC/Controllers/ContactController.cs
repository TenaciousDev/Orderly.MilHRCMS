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
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            var service = CreateContactService();
            var model = service.GetContacts();
            return View(model);
        }
        //GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateContactService();
            if (service.CreateContact(model))
            {
                TempData["Save Result"] = "Record created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Unable to create record.");
            return View(model);
        }
        //GET: Contact/Details/id
        public ActionResult Details(int id)
        {
            var svc = CreateContactService();
            var model = svc.GetContactByPersonnelId(id);
            return View(model);
        }
        //GET: Contact/Edit/id
        public ActionResult Edit(int id)
        {
            var svc = CreateContactService();
            var detail = svc.GetContactByPersonnelId(id);
            var model =
                new ContactEdit
                {
                    Id = detail.Id,
                    PersonnelId = detail.PersonnelId,
                    Personnel = detail.Personnel,
                    PhoneNumber = detail.PhoneNumber,
                    PersonalEmail = detail.PersonalEmail,
                    MilEmail = detail.MilEmail,
                    HasDriversLicense = detail.HasDriversLicense,
                    VehicleMake = detail.VehicleMake,
                    VehicleModel = detail.VehicleModel,
                    VehicleColor = detail.VehicleColor,
                    VehiclePlate = detail.VehiclePlate,
                    VehicleYear = detail.VehicleYear,
                    VehicleInspected = detail.VehicleInspected,
                    //CreatedBy = detail.CreatedBy,
                    //CreatedUtc = detail.CreatedUtc,
                    ModifiedLast = detail.ModifiedLast,
                    ModifiedUtc = detail.ModifiedUtc
                };
            return View(model);
        }
        //POST: Contact/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ContactEdit model)
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
            var svc = CreateContactService();
            if (svc.UpdateContact(model))
            {
                TempData["SaveResult"] = "Record updated.";
                return RedirectToAction("Details", new { id = model.PersonnelId });
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        private ContactService CreateContactService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ContactService(userId);
            return service;
        }
    }
}