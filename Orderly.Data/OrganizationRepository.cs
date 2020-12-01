using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Orderly.Data
{
    public class OrganizationRepository
    {
        public IEnumerable<SelectListItem> GetPlatoons()
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<SelectListItem> platoons = ctx.PlatoonDbSet.AsNoTracking()
                    .OrderBy(n => n.Name)
                    .Select(n =>
                    new SelectListItem
                    {
                        Value = n.PlatoonId.ToString(),
                        Text = n.Name
                    }
                    ).ToList();
                var platoonTip = new SelectListItem()
                {
                    Value = null,
                    Text = "--- select Platoon ---"
                };
                platoons.Insert(0, platoonTip);
                return new SelectList(platoons, "Value", "Text");
            }
        }
        public IEnumerable<SelectListItem> GetSquads()
        {
            List<SelectListItem> squads = new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Value = null,
                    Text = " "
                }
            };
            return squads;
        }
        public IEnumerable<SelectListItem> GetTeams()
        {
            List<SelectListItem> teams = new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Value = null,
                    Text = " "
                }
            };
            return teams;
        }
    }
}
