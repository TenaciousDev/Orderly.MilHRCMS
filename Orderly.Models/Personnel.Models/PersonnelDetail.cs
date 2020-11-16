using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class PersonnelDetail
    {
        public int PersonnelId { get; set; }
        public Grade Rank { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name / MI")]
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
