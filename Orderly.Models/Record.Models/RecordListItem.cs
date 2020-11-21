using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class RecordListItem
    {
        //Summary:
        //This item collects all properties related to personnel records.
        //It draws from the following classes: Personnel, Housing, Contact, and UnitInfo
        //A RecordListItem will return an IEnumerable of these classes' properties when
        //called as a the return type of a method.

        //PERSONNEL
        public int PersonnelId { get; set; }
        public Grade Rank { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        public BioSex Sex { get; set; }
        public string SSN { get; set; }
        [Display(Name = "DoD ID")]
        public string DOD { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTimeOffset DOB { get; set; }
        public TimeSpan Age
        {
            get
            {
                return DOB - DateTime.Now;
            }
        }
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }

        //CONTACT
        public int ContactId { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Personal Email")]
        public string PersonalEmail { get; set; }
        [Display(Name = ".mil Email")]
        public string MilEmail { get; set; }
        [Display(Name = "Drivers License?")]
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

        //HOUSING
        public int HousingId { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        [Display(Name = "Room #")]
        public string Room { get; set; }

        //UNITINFO
        public int UnitInfoId { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int SquadId { get; set; }
        public virtual Squad Squad { get; set; }
        public int PlatoonId { get; set; }
        public virtual Platoon Platoon { get; set; }
        public string Role { get; set; }
        [Display(Name = "Arrival Date")]
        public DateTimeOffset Arrived { get; set; }
        [Display(Name = "Loss Date")]
        public DateTimeOffset? LossDate { get; set; }
        [Display(Name = "Duty Status")]
        public string DutyStatus { get; set; }
    }
}
