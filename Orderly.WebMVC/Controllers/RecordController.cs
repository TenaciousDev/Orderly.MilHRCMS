using Microsoft.AspNet.Identity;
using Orderly.Data;
using Orderly.Models;
using Orderly.Services;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orderly.WebMVC.Controllers
{
    [Authorize]
    public class RecordController : Controller
    {

        //TEST
        public ActionResult GetRecordsTest()
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<RecordListItem> Records = new List<RecordListItem>();

                var recordList = (
                    from p in ctx.PersonnelDbSet
                    join u in ctx.Users on p.CreatedBy.ToString() equals u.Id
                    join c in ctx.ContactDbSet on p.PersonnelId equals c.PersonnelId
                    join ui in ctx.UnitInfoDbSet on p.PersonnelId equals ui.PersonnelId
                    join h in ctx.HousingDbSet on p.PersonnelId equals h.PersonnelId
                    //join sqd in ctx.SquadDbSet on ui.Team.Squad.SquadId equals sqd.Id
                    //join plt in ctx.PlatoonDbSet on ui.Team.Squad.Platoon.PlatoonId equals plt.Id
                    select new
                    {
                        //Personnel
                        p.PersonnelId,
                        p.Rank,
                        p.FirstName,
                        p.LastName,
                        p.MiddleName,
                        p.Sex,
                        p.SSN,
                        p.DOD,
                        p.DOB,
                        p.MaritalStatus,
                        //Contact
                        c.ContactId,
                        c.PhoneNumber,
                        c.PersonalEmail,
                        c.MilEmail,
                        c.HasDriversLicense,
                        c.VehicleMake,
                        c.VehicleModel,
                        c.VehicleColor,
                        c.VehiclePlate,
                        c.VehicleYear,
                        c.VehicleInspected,
                        //Housing
                        h.HousingId,
                        h.Address,
                        h.Room,
                        //UnitInfo
                        ui.UnitInfoId,
                        ui.TeamId,
                        //sqd.SquadId,
                        //plt.PlatoonId,
                        ui.Role,
                        ui.Arrived,
                        ui.LossDate,
                        ui.DutyStatus
                    }).ToList();
                foreach (var model in recordList)
                {
                    RecordListItem record = new RecordListItem();
                    //Personnel
                    record.PersonnelId = model.PersonnelId;
                    record.Rank = model.Rank;
                    record.FirstName = model.FirstName;
                    record.LastName = model.LastName;
                    record.MiddleName = model.MiddleName;
                    record.Sex = model.Sex;
                    record.SSN = model.SSN;
                    record.DOD = model.DOD;
                    record.DOB = model.DOB;
                    record.MaritalStatus = model.MaritalStatus;
                    //Contact
                    record.PersonnelId = model.PersonnelId;
                    record.PhoneNumber = model.PhoneNumber;
                    record.PersonalEmail = model.PersonalEmail;
                    record.MilEmail = model.MilEmail;
                    record.HasDriversLicense = model.HasDriversLicense;
                    record.VehicleMake = model.VehicleMake;
                    record.VehicleModel = model.VehicleModel;
                    record.VehicleColor = model.VehicleColor;
                    record.VehicleYear = model.VehicleYear;
                    record.VehicleInspected = model.VehicleInspected;
                    //Housing
                    record.PersonnelId = model.PersonnelId;
                    record.Address = model.Address;
                    record.Room = model.Room;
                    //UnitInfo
                    record.PersonnelId = model.PersonnelId;
                    record.TeamId = model.TeamId;
                    record.Role = model.Role;
                    record.Arrived = model.Arrived;
                    record.LossDate = model.LossDate;
                    record.DutyStatus = model.DutyStatus;

                    Records.Add(record);
                }
                return View(Records);
            }
        }
        //GET: Record TEST INDEX
        public ActionResult TestIndex()
        {
            var personnelSvc = CreatePersonnelService();
            var contactSvc = CreateContactService();
            var housingSvc = CreateHousingService();
            var unitInfoSvc = CreateUnitInfoService();
            dynamic testModel = new ExpandoObject();
            testModel.Personnel = personnelSvc.GetPersonnel();
            testModel.Contact = contactSvc.GetContacts();
            testModel.Housing = housingSvc.GetHousing();
            testModel.UnitInfo = unitInfoSvc.GetUnitInfo();
            return View(testModel);
        }

        //GET: Record/Create TEST
        public ActionResult TestCreate()
        {
            var personnelSvc = CreatePersonnelService();
            var contactSvc = CreateContactService();
            var housingSvc = CreateHousingService();
            var unitInfoSvc = CreateUnitInfoService();
            dynamic testModel = new ExpandoObject();
            testModel.Personnel = personnelSvc.GetPersonnel();
            testModel.Contact = contactSvc.GetContacts();
            testModel.Housing = housingSvc.GetHousing();
            testModel.UnitInfo = unitInfoSvc.GetUnitInfo();
            return View(testModel);
        }

        //POST Record/Create TEST
/*        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TestCreate()
        { 
        }*/

        // GET: Record
        public ActionResult Index()
        {
            var service = CreateRecordService();
            var model = service.GetRecords();
            return View(model);
        }

        //GET: Record MAIN PAGE THIS IS A TEST
        public ActionResult Dashboard()
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
        //GET: Record/CreatePersonnelRecord
        public ActionResult CreatePersonnelRecord()
        {
            return View();
        }
        //GET: Record/CreateContactRecord
        public ActionResult CreateContactRecord()
        {
            return View();
        }
        //GET: Record/CreateHousingRecord
        public ActionResult CreateHousingRecord()
        {
            return View();
        }
        //GET: Record/CreateUnitInfoRecord
        public ActionResult CreateUnitInfoRecord()
        {
            return View();
        }
        //GET: Record/Assign
        public ActionResult Assign()
        {
            return View();
        }
        //GET: Record/UpdatePersonal/id
        public ActionResult UpdatePersonal(int id)
        {
            var svc = CreateRecordService();
            var model = svc.GetRecordByPersonnelId(id);
            return View(model);
        }
        //GET: Record/UpdateContact/id
        public ActionResult UpdateContact(int id)
        {
            var svc = CreateRecordService();
            var model = svc.GetRecordByPersonnelId(id);
            return View(model);
        }
        //GET: Record/UpdateHousing/id
        public ActionResult UpdateHousing(int id)
        {
            var svc = CreateRecordService();
            var model = svc.GetRecordByPersonnelId(id);
            return View(model);
        }
        //GET: Record/UpdateOrganization/id
        public ActionResult UpdateOrganization(int id)
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
        //[Route("Personnel/Edit/{id}")]
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
                return RedirectToAction("Details", new { id = model.PersonnelId });
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        //GET: Contact/Edit/id
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
                return RedirectToAction("Details", new { id = model.PersonnelId });
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        //GET: Housing/Edit/id
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
                return RedirectToAction("Details", new { id = model.PersonnelId });
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        //GET: UnitInfo/Edit/id
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
                return RedirectToAction("Details", new { id = model.PersonnelId });
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