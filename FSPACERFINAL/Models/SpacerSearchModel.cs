using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FSPACERFINAL.Models
{
    public class SpacerSearchModel
    {
        public string SearchDriveNumber { get; set; }
        public int SearchOperatorID { get; set; }
        public DateTime SearchDate { get; set; }

        //public DateTime? DateFrom { get; set; }
        //public DateTime? DateTo { get; set; }
        //public List<SpacerCard> SpacerCards { get; set; }     
    }
}
