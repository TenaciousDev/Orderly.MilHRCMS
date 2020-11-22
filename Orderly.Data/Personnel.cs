using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Data
{
    public enum Grade { E1, E2, E3, E4, E5, E6, E7, E8, E9, O1, O2, O3, O4, O5, O6, O7, O8, O9, O10, W1, W2, W3, W4, W5 }
/*    public struct ServiceRank
    {
        public string Grade { get; set; }
        public string Rank { get; set; }
        public bool MustResideInBarracks { get; set; }
        public decimal Salary { get; set; }
        public decimal BAH { get; set; }
        public decimal BAS { get; set; }

        public ServiceRank E1(string grade, string rank)
        {
            Grade = grade;
            Rank = rank;
            return E1("E1","PV1");
        }
    }*/
    public enum BioSex { Male, Female, Other}
    public enum Gender { }
    public enum MaritalStatus { NeverMarried, Married, Divorced, Widowed, Estranged, Other}
    public class Personnel
    {
        [Key]
        public int PersonnelId { get; set; }
        [Required]
        public Grade Rank { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name")]
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
        public int Age
        {
            get
            {
                var age = DateTime.Now.Year - DOB.Year;
                if (DOB.Date > DateTime.Now.AddYears(-age)) age--;
                return age;
            }
        }
        [Required]
        [Display(Name ="Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }
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
