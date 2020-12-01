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
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            var service = CreateTeamService();
            var model = service.GetTeams();
            return View(model);
        }
        //GET: Team/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Team/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeamCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateTeamService();
            if (service.CreateTeam(model))
            {
                TempData["Save Result"] = "Record created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Unable to create record.");
            return View(model);
        }
        //GET: Team/Details/id
        public ActionResult Details(int id)
        {
            var svc = CreateTeamService();
            var model = svc.GetTeamById(id);
            return View(model);
        }
        //GET: Team/Edit/id
        public ActionResult Edit(int id)
        {
            var svc = CreateTeamService();
            var detail = svc.GetTeamById(id);
            var model =
                new TeamEdit
                {
                    Id = detail.Id,
                    Name = detail.Name,
                    Familiar = detail.Familiar,
                    Assigned = detail.Assigned,
                };
            return View(model);
        }
        //POST: Team/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TeamEdit model)
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
            var svc = CreateTeamService();
            if (svc.UpdateTeam(model))
            {
                TempData["SaveResult"] = "Record updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Unable to update record.");
            return View();
        }
        private TeamService CreateTeamService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TeamService(userId);
            return service;
        }

    }
}