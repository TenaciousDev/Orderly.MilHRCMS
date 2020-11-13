using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        [ForeignKey(nameof(PersonnelId))]
        public virtual Personnel Personnel { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonalEmail { get; set; }
        public string MilEmail { get; set; }
        public bool HasDriversLicense { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehiclePlate { get; set; }
        public int VehicleYear { get; set; }
        public DateTimeOffset? VehicleInspected { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedLast { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
