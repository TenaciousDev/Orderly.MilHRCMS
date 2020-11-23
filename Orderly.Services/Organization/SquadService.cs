using Orderly.Data;
using Orderly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Services
{
    public class SquadService
    {
        private readonly Guid _userId;
        public SquadService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateSquad(SquadCreate model)
        {
            var entity = new Squad()
            {
                PlatoonId = model.PlatoonId,
                Platoon = model.Platoon,
                Name = model.Name,
                Familiar = model.Familiar
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.SquadDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<SquadListItem> GetSquads()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .SquadDbSet
                    .Select(
                        e =>
                        new SquadListItem
                        {
                            Id = e.Id,
                            PlatoonId = e.PlatoonId,
                            Platoon = e.Platoon,
                            Name = e.Name,
                            Familiar = e.Familiar,
                            Assigned = e.Assigned,
                            Teams = e.Teams
                        }
                        );
                return query.ToArray();
            }
        }
        public SquadDetail GetSquadById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .SquadDbSet
                    .Single(e => e.Id == id);
                return
                    new SquadDetail
                    {
                        PlatoonId = entity.PlatoonId,
                        Platoon = entity.Platoon,
                        Name = entity.Name,
                        Familiar = entity.Familiar,
                        Assigned = entity.Assigned,
                        Teams = entity.Teams
                    };
            }
        }
        public bool UpdateSquad(SquadEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .SquadDbSet
                    .Single(e => e.Id == model.Id);
                entity.PlatoonId = model.PlatoonId;
                entity.Platoon = model.Platoon;
                entity.Name = model.Name;
                entity.Familiar = model.Familiar;
                entity.Assigned = model.Assigned;
                entity.Teams = model.Teams;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
