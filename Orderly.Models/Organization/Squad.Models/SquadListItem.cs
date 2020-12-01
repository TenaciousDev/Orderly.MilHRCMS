using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class SquadListItem
    {
        public int Id { get; set; }
        public int PlatoonId { get; set; }
        public virtual Platoon Platoon { get; set; }
        public string Name { get; set; }
        public string Familiar { get; set; }
        [Display(Name = "Personnel Assigned")]
        public List<Personnel> Assigned { get; set; } = new List<Personnel>();
        public List<Team> Teams { get; set; } = new List<Team>();
    }
}
