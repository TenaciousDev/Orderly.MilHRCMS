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
    public class UnitInfoController : Controller
    {
        // GET: UnitInfo
        public ActionResult Index()
        {
            var service = CreateUnitInfoService();
            var model = service.GetUnitInfo();
            return View(model);
        }
        //GET: UnitInfo/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: UnitInfo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UnitInfoCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateUnitInfoService();
            if (service.CreateUnitInfo(model))
            {
                TempData["Save Result"] = "Record created.";
                return RedirectToAction("Index","Record");
            };
            ModelState.AddModelError("", "Unable to create record.");
            return View(model);
        }
        //GET: UnitInfo/Details/id
        public ActionResult Details(int id)
        {
            var svc = CreateUnitInfoService();
            var model = svc.GetUnitInfoByPersonnelId(id);
            return View(model);
        }
        //GET: UnitInfo/Edit/id
        public ActionResult Edit(int id)
        {
            var svc = CreateUnitInfoService();
            var detail = svc.GetUnitInfoByPersonnelId(id);
            var model =
                new UnitInfoEdit
                {
                    Id = detail.Id,
                    PersonnelId = detail.PersonnelId,
                    Personnel = detail.Personnel,
                    //TeamId = detail.TeamId,
                    SelectedTeam = detail.TeamId,
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
        public ActionResult Edit(int id, UnitInfoEdit model)
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
                return RedirectToAction("Index","Record");
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        private UnitInfoService CreateUnitInfoService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new UnitInfoService(userId);
            return service;
        }
    }
}