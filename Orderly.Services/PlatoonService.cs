using Orderly.Data;
using Orderly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Services
{
    public class PlatoonService
    {
        private readonly Guid _userId;
        public PlatoonService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreatePlatoon(PlatoonCreate model)
        {
            var entity = new Platoon()
            {
                Name = model.Name,
                Familiar = model.Familiar
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.PlatoonDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<PlatoonListItem> GetPlatoons()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .PlatoonDbSet
                    .Select(
                        e =>
                        new PlatoonListItem
                        {
                            Id = e.PlatoonId,
                            Name = e.Name,
                            Familiar = e.Familiar,
                            Assigned = e.Assigned,
                            Squads = e.Squads,
                            Teams = e.Teams
                        }
                        );
                return query.ToArray();
            }
        }
        public PlatoonDetail GetPlatoonById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .PlatoonDbSet
                    .Single(e => e.PlatoonId == id);
                return
                    new PlatoonDetail
                    {
                        Name = entity.Name,
                        Familiar = entity.Familiar,
                        Assigned = entity.Assigned,
                        Squads = entity.Squads,
                        Teams = entity.Teams
                    };
            }
        }
        public bool UpdatePlatoon(PlatoonEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .PlatoonDbSet
                    .Single(e => e.PlatoonId == model.Id);
                entity.Name = model.Name;
                entity.Familiar = model.Familiar;
                entity.Assigned = model.Assigned;
                entity.Squads = model.Squads;
                entity.Teams = model.Teams;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
