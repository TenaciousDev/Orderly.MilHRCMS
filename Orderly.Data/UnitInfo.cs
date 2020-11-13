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
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        [ForeignKey(nameof(PersonnelId))]
        public virtual Personnel Personnel { get; set; }
        public int TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public virtual Team Team { get; set; }
        public string Role { get; set; }
        public DateTimeOffset Arrived { get; set; }
        public string DutyStatus { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedLast { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
