using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class TeamDetail
    {
        public int Id { get; set; }
        public int SquadId { get; set; }
        public virtual Squad Squad { get; set; }
        [Required]
        public string Name { get; set; }
        public string Familiar { get; set; }
        public List<Personnel> Assigned { get; set; } = new List<Personnel>();
    }
}
