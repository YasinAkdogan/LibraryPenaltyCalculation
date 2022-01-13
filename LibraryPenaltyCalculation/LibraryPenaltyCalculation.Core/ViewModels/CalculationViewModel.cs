using LibraryPenaltyCalculation.Core.Models;
using LibraryPenaltyCalculation.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Core.ViewModels
{
    public class CalculationViewModel
    {        
        public DateTime TakenDate { get; set; }
        public DateTime GivenDate { get; set; }
        public int CountryId { get; set; }      
    }
}
