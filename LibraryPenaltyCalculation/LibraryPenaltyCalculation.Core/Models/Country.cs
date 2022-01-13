using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Core.Models
{
    public class Country
    {
        public Country()
        {
            NationalHolidays = new Collection<NationalHoliday>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }

        public string Weekend { get; set; }
        public string Weekend2 { get; set; }
        public ICollection<NationalHoliday> NationalHolidays { get; set; }
    }
}
