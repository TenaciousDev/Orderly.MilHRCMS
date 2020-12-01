using Orderly.Data;
using Orderly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Services
{
    public class UnitInfoService
    {
        private readonly Guid _userId;
        public UnitInfoService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateUnitInfo(UnitInfoCreate model)
        {
            var entity = new UnitInfo()
            {
                PersonnelId = model.PersonnelId,
                Personnel = model.Personnel,
                TeamId = model.TeamId,
                Team = model.Team,
                Role = model.Role,
                Arrived = model.Arrived,
                LossDate = model.LossDate,
                DutyStatus = model.DutyStatus,
                CreatedBy = _userId,
                CreatedUtc = DateTimeOffset.Now,
                ModifiedLast = Guid.Empty
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.UnitInfoDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<UnitInfoListItem> GetUnitInfo()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    from e in ctx.UnitInfoDbSet
                    join u in ctx.Users
                    on e.CreatedBy.ToString() equals u.Id
                    join m in ctx.Users
                    on e.ModifiedLast.ToString() equals m.Id
                    join sq in ctx.UnitInfoDbSet on e.Team.Squad.Id equals sq.Id
                    join plt in ctx.UnitInfoDbSet on e.Team.Squad.Platoon.Id equals plt.Id
                    select new UnitInfoListItem
                    {
                        Id = e.Id,
                        PersonnelId = e.PersonnelId,
                        Personnel = e.Personnel,
                        TeamId = e.TeamId,
                        Team = e.Team,
                        Role = e.Role,
                        Arrived = e.Arrived,
                        LossDate = e.LossDate,
                        DutyStatus = e.DutyStatus,
                        CreatedByUserName = u.UserName,
                        CreatedBy = e.CreatedBy,
                        CreatedUtc = e.CreatedUtc,
                        ModifiedByUserName = m.UserName,
                        ModifiedLast = e.ModifiedLast,
                        ModifiedUtc = e.ModifiedUtc
                    };
                return query.ToArray();
            }
        }
        public UnitInfoDetail GetUnitInfoByPersonnelId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var record = (
                    from entity in ctx.UnitInfoDbSet
                    join u in ctx.Users
                    on entity.CreatedBy.ToString() equals u.Id
                    join m in ctx.Users
                    on entity.ModifiedLast.ToString() equals m.Id
                    join sq in ctx.UnitInfoDbSet on entity.Team.Squad.Id equals sq.Id
                    join plt in ctx.UnitInfoDbSet on entity.Team.Squad.Platoon.Id equals plt.Id
                    where entity.PersonnelId == id
                    select new UnitInfoDetail
                    {
                        Id = entity.Id,
                        PersonnelId = entity.PersonnelId,
                        Personnel = entity.Personnel,
                        TeamId = entity.TeamId,
                        Team = entity.Team,
                        Role = entity.Role,
                        Arrived = entity.Arrived,
                        LossDate = entity.LossDate,
                        DutyStatus = entity.DutyStatus,
                        CreatedByUserName = u.UserName,
                        CreatedBy = entity.CreatedBy,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedByUserName = m.UserName,
                        ModifiedLast = entity.ModifiedLast,
                        ModifiedUtc = entity.ModifiedUtc
                    }).SingleOrDefault();
                return record;
            }
        }
        public bool UpdateUnitInfo(UnitInfoEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var linkedSquad = ctx.UnitInfoDbSet.Find(model.Team.Squad);
                var sqd = ctx.SquadDbSet.Find(linkedSquad.Id);
                var linkedPlatoon = ctx.UnitInfoDbSet.Find(model.Team.Squad.Platoon);
                var plt = ctx.PlatoonDbSet.Find(linkedPlatoon.Id);
                var user = ctx.Users.Find(_userId.ToString());
                var userName = user.UserName;
                var entity =
                    ctx
                    .UnitInfoDbSet
                    .Single(e => e.Id == model.Id);
                entity.PersonnelId = model.PersonnelId;
                entity.Personnel = model.Personnel;
                entity.TeamId = model.TeamId;
                entity.Team = model.Team;
                entity.Team.Squad.Id = sqd.Id;
                entity.Team.Squad.Platoon.Id = plt.Id;
                entity.Role = model.Role;
                entity.Arrived = model.Arrived;
                entity.LossDate = model.LossDate;
                entity.DutyStatus = model.DutyStatus;
                entity.ModifiedByUserName = userName;
                entity.ModifiedLast = _userId;
                entity.ModifiedUtc = DateTimeOffset.Now;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
