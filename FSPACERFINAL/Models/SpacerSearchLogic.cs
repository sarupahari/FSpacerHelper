using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSPACERFINAL.Data;


namespace FSPACERFINAL.Models
{
    public class SpacerSearchLogic
    {
        //private ApplicationDbContext _context;

        //public SpacerSearchLogic(ApplicationDbContext context)
        //{

        //    _context = context;
        //}

        //public IQueryable<SpacerCard> GetCards(SpacerSearchModel searchModel)
        //{
        //    var result = _context.SpacerCards.AsQueryable();
        //    if (searchModel != null)
        //    {
        //        if (!String.IsNullOrEmpty(searchModel.DriveNumber))
        //        {
        //            result = result.Where(x => x.DriveNumber.Contains(searchModel.DriveNumber));
        //        }
        //        if (searchModel.OperatorID.HasValue)
        //        {
        //            result = result.Where(x => x.OperatorID == searchModel.OperatorID);
        //        }
        //        if (searchModel.DateFrom.HasValue)
        //        {
        //            result = result.Where(x => x.Date >= searchModel.DateFrom);
        //        }
        //        if (searchModel.DateTo.HasValue)
        //        {
        //            result = result.Where(x => x.Date <= searchModel.DateTo);
        //        }
        //    }

        //    return result;
        //}
    }
}
