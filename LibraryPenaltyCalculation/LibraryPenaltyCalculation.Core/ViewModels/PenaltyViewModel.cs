using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Core.ViewModels
{
   public class PenaltyViewModel
    {
        public int TotalDay { get; set; }
        public int CalculationDay { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal Amercement { get; set; }       
        public string Currency { get; set; }
        public Dictionary<DateTime, string> HolidayDays { get; set; }
        public PenaltyViewModel()
        {
            this.HolidayDays = new Dictionary<DateTime, string>();
        }
    }
}
