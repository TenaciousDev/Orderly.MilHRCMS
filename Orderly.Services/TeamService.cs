using Orderly.Data;
using Orderly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Services
{
    public class TeamService
    {
        private readonly Guid _userId;
        public TeamService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateTeam(TeamCreate model)
        {
            var entity = new Team()
            {
                SquadId = model.SquadId,
                Squad = model.Squad,
                Name = model.Name,
                Familiar = model.Familiar
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.TeamDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<TeamListItem> GetTeams()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .TeamDbSet
                    .Select(
                        e =>
                        new TeamListItem
                        {
                            Id = e.TeamId,
                            SquadId = e.SquadId,
                            Squad = e.Squad,
                            Name = e.Name,
                            Familiar = e.Familiar,
                            Assigned = e.Assigned
                        }
                        );
                return query.ToArray();
            }
        }
        public TeamDetail GetTeamById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .TeamDbSet
                    .Single(e => e.TeamId == id);
                return
                    new TeamDetail
                    {
                        SquadId = entity.SquadId,
                        Squad = entity.Squad,
                        Name = entity.Name,
                        Familiar = entity.Familiar,
                        Assigned = entity.Assigned
                    };
            }
        }
        public bool UpdateTeam(TeamEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .TeamDbSet
                    .Single(e => e.TeamId == model.Id);
                entity.SquadId = model.SquadId;
                entity.Squad = model.Squad;
                entity.Name = model.Name;
                entity.Familiar = model.Familiar;
                entity.Assigned = model.Assigned;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
