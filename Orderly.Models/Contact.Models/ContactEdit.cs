using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class ContactEdit
    {
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Personal Email")]
        public string PersonalEmail { get; set; }
        [Display(Name = ".mil Email")]
        public string MilEmail { get; set; }
        [Display(Name = "Does SM have Drivers License?")]
        public bool HasDriversLicense { get; set; }
        [Display(Name = "Vehicle Make")]
        public string VehicleMake { get; set; }
        [Display(Name = "Vehicle Model")]
        public string VehicleModel { get; set; }
        [Display(Name = "Vehicle Model")]
        public string VehicleColor { get; set; }
        [Display(Name = "Vehicle Color")]
        public string VehiclePlate { get; set; }
        [Display(Name = "Vehicle Year")]
        public int VehicleYear { get; set; }
        [Display(Name = "Last Vehicle Inspection")]
        public DateTimeOffset? VehicleInspected { get; set; }
        [Display(Name = "Created by")]
        public Guid CreatedBy { get; set; }
        [Display(Name = "Last modified by")]
        public Guid ModifiedLast { get; set; }
        [Display(Name = "Created on")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Modified on")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
