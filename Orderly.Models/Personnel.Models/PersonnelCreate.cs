using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class PersonnelCreate
    {
        [Required]
        public Grade Rank { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name / MI")]
        public string MiddleName { get; set; }
        [Required]
        public BioSex Sex { get; set; }
        [Required]
        public string SSN { get; set; }
        [Required]
        [Display(Name = "DoD ID")]
        public string DOD { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTimeOffset DOB { get; set; }
        [Required]
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }
        [Display(Name = "Created by")]
        public Guid CreatedBy { get; set; }
        [Display(Name = "Last modified by")]
        public Guid ModifiedLast { get; set; }
        [Display(Name = "Created on")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
