using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Data
{
    public class Platoon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Platoon")]
        public string Name { get; set; }
        public string Familiar { get; set; }
        [Display(Name = "Personnel Assigned")]
        public List<Personnel> Assigned { get; set; } = new List<Personnel>();
        public List<Squad> Squads { get; set; } = new List<Squad>();
        public List<Team> Teams { get; set; } = new List<Team>();
    }
}
