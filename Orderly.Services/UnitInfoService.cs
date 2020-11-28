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
        public List<Platoon> Platoons = new List<Platoon>();
        public List<Squad> Squads = new List<Squad>();
        public List<Team> Teams = new List<Team>();
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
                    join sq in ctx.UnitInfoDbSet on e.Team.Squad.SquadId equals sq.Team.SquadId
                    join plt in ctx.UnitInfoDbSet on e.Team.Squad.Platoon.PlatoonId equals plt.Team.Squad.PlatoonId
                    select new UnitInfoListItem
                    {
                        Id = e.UnitInfoId,
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
                var mod = ctx.Users.Find(_userId.ToString());
                var record = (
                    from entity
                    in ctx.UnitInfoDbSet
                    join u in ctx.Users
                    on entity.CreatedBy.ToString()
                    equals u.Id
/*                    join m in ctx.Users
                    on entity.ModifiedLast.ToString()
                    equals m.Id
*/                    join sq in ctx.UnitInfoDbSet on entity.Team.Squad.SquadId equals sq.Team.SquadId
                    join plt in ctx.UnitInfoDbSet on entity.Team.Squad.Platoon.PlatoonId equals plt.Team.Squad.PlatoonId
                    where entity.PersonnelId == id
                    select new UnitInfoDetail
                    {
                        Id = entity.UnitInfoId,
                        PersonnelId = entity.PersonnelId,
                        Personnel = entity.Personnel,
                        TeamId = entity.TeamId,
                        Team = entity.Team,
                        Squad = entity.Team.Squad,
                        SquadId = entity.Team.Squad.SquadId,
                        Platoon = entity.Team.Squad.Platoon,
                        PlatoonId = entity.Team.Squad.Platoon.PlatoonId,
                        Role = entity.Role,
                        Arrived = entity.Arrived,
                        LossDate = entity.LossDate,
                        DutyStatus = entity.DutyStatus,
                        CreatedByUserName = u.UserName,
                        CreatedBy = entity.CreatedBy,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedByUserName = entity.ModifiedByUserName,
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
                var user = ctx.Users.Find(_userId.ToString());
                var userName = user.UserName;
                var entity =
                    ctx
                    .UnitInfoDbSet
                    .Single(e => e.UnitInfoId == model.Id);
                entity.PersonnelId = model.PersonnelId;
                entity.Personnel = model.Personnel;



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
