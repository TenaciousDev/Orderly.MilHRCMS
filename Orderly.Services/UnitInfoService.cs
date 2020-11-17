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
                    ctx
                    .UnitInfoDbSet
                    .Select(
                        e =>
                        new UnitInfoListItem
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
                            CreatedBy = e.CreatedBy,
                            CreatedUtc = e.CreatedUtc,
                            ModifiedLast = e.ModifiedLast,
                            ModifiedUtc = e.ModifiedUtc
                        }
                        );
                return query.ToArray();
            }
        }
        public UnitInfoDetail GetUnitInfoByPersonnelId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .UnitInfoDbSet
                    .Single(e => e.PersonnelId == id);
                return
                    new UnitInfoDetail
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
                        CreatedBy = entity.CreatedBy,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedLast = entity.ModifiedLast,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateUnitInfo(UnitInfoEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .UnitInfoDbSet
                    .Single(e => e.Id == model.Id);
                entity.PersonnelId = model.PersonnelId;
                entity.Personnel = model.Personnel;
                entity.TeamId = model.TeamId;
                entity.Team = model.Team;
                entity.Role = model.Role;
                entity.Arrived = model.Arrived;
                entity.LossDate = model.LossDate;
                entity.DutyStatus = model.DutyStatus;
                entity.CreatedBy = model.CreatedBy;
                entity.CreatedUtc = model.CreatedUtc;
                entity.ModifiedLast = _userId;
                entity.ModifiedUtc = DateTimeOffset.Now;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
