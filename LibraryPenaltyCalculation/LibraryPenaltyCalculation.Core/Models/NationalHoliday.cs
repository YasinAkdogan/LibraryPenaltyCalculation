using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Core.Models
{
    public class NationalHoliday
    {
        public int Id { get; set; }
        public string HolidayName { get; set; }
        public DateTime Date { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
