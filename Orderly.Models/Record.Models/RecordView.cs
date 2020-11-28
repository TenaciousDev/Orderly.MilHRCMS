using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class RecordView
    {
        public int PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }
        public int? ContactId { get; set; }
        public virtual Contact Contact { get; set; }
        public int? HousingId { get; set; }
        public virtual Housing Housing { get; set; }
        public int? UnitInfoId { get; set; }
        public virtual UnitInfo UnitInfo { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int? SquadId { get; set; }
        public virtual Squad Squad { get; set; }
        public int? PlatoonId { get; set; }
        public virtual Platoon Platoon { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        [Display(Name = "Last modified by")]
        public ApplicationUser ModifiedBy { get; set; }
        [Display(Name = "Created on")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Modified on")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
