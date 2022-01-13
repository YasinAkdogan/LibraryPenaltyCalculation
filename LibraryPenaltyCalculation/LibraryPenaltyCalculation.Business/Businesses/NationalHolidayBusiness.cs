using LibraryPenaltyCalculation.Core.Businesses;
using LibraryPenaltyCalculation.Core.Models;
using LibraryPenaltyCalculation.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Business.Businesses
{
   public class NationalHolidayBusiness : Business<NationalHoliday>, INationalHolidayBusiness
    {
        public NationalHolidayBusiness(IRepository<NationalHoliday> repository) : base(repository)
        {

        }
    }
}
