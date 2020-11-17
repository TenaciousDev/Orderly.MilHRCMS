using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Data
{
    public enum Grade { E1, E2, E3, E4, E5, E6, E7, E8, E9, O1, O2, O3, O4, O5, O6, O7, O8, O9, O10, W1, W2, W3, W4, W5 }
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
        public TimeSpan Age
        {
            get
            {
                return DateTime.Now - DOB;
            }
        }
        [Required]
        [Display(Name ="Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }
        [Display(Name = "Created by")]
        public Guid CreatedBy { get; set; } // Look into making this Type: ApplicationUser https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.entityframeworkcore.identityuser?view=aspnetcore-1.1
        [Display(Name = "Last modified by")]
        public Guid ModifiedLast { get; set; }
        [Display(Name = "Created on")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Modified on")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
