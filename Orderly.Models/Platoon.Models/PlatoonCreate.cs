using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class PlatoonCreate
    {
        [Required]
        [Display(Name = "Official Designation")]
        public string Name { get; set; }
        [Display(Name = "Familiar Name")]
        public string Familiar { get; set; }
    }
}
