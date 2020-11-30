using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Orderly.Models
{
    public class PlatoonDropDown
    {
        public UnitInfoListItem PlatoonDropDownModel { get; set; }
        public SelectList PlatoonSelectList { get; set; }
        public PlatoonDropDown()
        {
            PlatoonDropDownModel = new UnitInfoListItem();
        }
    }
}
