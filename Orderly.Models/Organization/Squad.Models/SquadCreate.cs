using Orderly.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class SquadCreate
    {
        public int PlatoonId { get; set; }
        public virtual Platoon Platoon { get; set; }
        public string Name { get; set; }
        public string Familiar { get; set; }
    }
}
