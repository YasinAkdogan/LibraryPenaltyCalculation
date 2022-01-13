using LibraryPenaltyCalculation.Core.Models;
using LibraryPenaltyCalculation.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Business
{
   public interface ICalculationPenalty
    {
        PenaltyViewModel CalculatePenalty(CalculationViewModel model, string weekend, string weekend2, IEnumerable<NationalHoliday> nationalHoliday, string Currency);
    }
}
