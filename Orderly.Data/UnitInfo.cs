using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Data
{
    public class UnitInfo
    {
        [Key]
        public int UnitInfoId { get; set; }
        public int PersonnelId { get; set; }
        [ForeignKey(nameof(PersonnelId))]
        public virtual Personnel Personnel { get; set; }
        public int TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public virtual Team Team { get; set; }
        public string Role { get; set; }
        [Display(Name = "Arrival Date")]
        public DateTimeOffset Arrived { get; set; }
        [Display(Name = "Loss Date")]
        public DateTimeOffset? LossDate { get; set; }
        [Display(Name = "Duty Status")]
        public string DutyStatus { get; set; }
        [Display(Name = "Created by")]
        public string CreatedByUserName { get; set; }
        public Guid CreatedBy { get; set; }
        [Display(Name = "Last modified by")]
        public string ModifiedByUserName { get; set; }
        public Guid ModifiedLast { get; set; }
        [Display(Name = "Created on")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Modified on")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
