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
    [RoutePrefix("/Record")]
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
        //GET: Record/Edit/id
        public ActionResult Edit(int id)
        {
            var svc = CreateRecordService();
            var detail = svc.GetRecordByPersonnelId(id);
            var model =
                new RecordEdit
                {
                    //Personnel
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
                    ModifiedUtc = detail.ModifiedUtc,
                    //Contact
                    ContactId = detail.ContactId,
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
                    //Housing
                    Address = detail.Address,
                    Room = detail.Room,
                    //UnitInfo
                    TeamId = detail.TeamId,
                    Team = detail.Team,
                    Role = detail.Role,
                    Arrived = detail.Arrived,
                    LossDate = detail.LossDate,
                    DutyStatus = detail.DutyStatus
                };
            return View(model);
        }
        //GET: Record/Edit/Personnel/id
        [Route("Personnel/Edit/{id}")]
        public ActionResult EditPersonnel(int id)
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
        //POST: Record/Edit/Personnel/id
        [Route("Personnel/Edit/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPersonnel(int id, PersonnelEdit model)
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
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        //GET: Contact/Edit/id
        [Route("Contact/Edit/{id}")]
        public ActionResult EditContact(int id)
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
        [Route("Contact/Edit/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditContact(int id, ContactEdit model)
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
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        //GET: Housing/Edit/id
        [Route("Housing/Edit/{id}")]
        public ActionResult EditHousing(int id)
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
        [Route("Housing/Edit/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditHousing(int id, HousingEdit model)
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
        //GET: UnitInfo/Edit/id
        [Route("UnitInfo/Edit/{id}")]
        public ActionResult EditUnitInfo(int id)
        {
            var svc = CreateUnitInfoService();
            var detail = svc.GetUnitInfoByPersonnelId(id);
            var model =
                new UnitInfoEdit
                {
                    Id = detail.Id,
                    PersonnelId = detail.PersonnelId,
                    Personnel = detail.Personnel,
                    TeamId = detail.TeamId,
                    Team = detail.Team,
                    Role = detail.Role,
                    Arrived = detail.Arrived,
                    LossDate = detail.LossDate,
                    DutyStatus = detail.DutyStatus,
                    //CreatedBy = detail.CreatedBy,
                    //CreatedUtc = detail.CreatedUtc,
                    ModifiedLast = detail.ModifiedLast,
                    ModifiedUtc = detail.ModifiedUtc
                };
            return View(model);
        }
        //POST: UnitInfo/Edit/id
        [Route("UnitInfo/Edit/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditUnitInfo(int id, UnitInfoEdit model)
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
            var svc = CreateUnitInfoService();
            if (svc.UpdateUnitInfo(model))
            {
                TempData["SaveResult"] = "Record updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        //CreateService Methods
        private RecordService CreateRecordService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RecordService(userId);
            return service;
        }
        private PersonnelService CreatePersonnelService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PersonnelService(userId);
            return service;
        }
        private ContactService CreateContactService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ContactService(userId);
            return service;
        }
        private HousingService CreateHousingService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new HousingService(userId);
            return service;
        }
        private UnitInfoService CreateUnitInfoService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new UnitInfoService(userId);
            return service;
        }
    }
}