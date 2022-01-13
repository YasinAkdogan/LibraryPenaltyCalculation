using LibraryPenaltyCalculation.Core.Models;
using LibraryPenaltyCalculation.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryPenaltyCalculation.Business
{
    public class CalculationPenalty : ICalculationPenalty
    {
        public PenaltyViewModel CalculatePenalty(CalculationViewModel model,string weekend,string weekend2, IEnumerable<NationalHoliday> nationalHoliday,string Currency)
        {
            var penaltyViewModel = new PenaltyViewModel();
            var result = model.TakenDate.Date - model.GivenDate.Date;
            var days = result.TotalDays+1;           
            int totalDay =Convert.ToInt32(days);
            penaltyViewModel.TotalDay = totalDay;
            if (days >=11)
            {
                for (DateTime i = model.GivenDate.Date; i <= model.TakenDate.Date; i = i.AddDays(1))
                {
                    string DayName = i.DayOfWeek.ToString();
                    if (nationalHoliday.Any(x => x.Date == i))
                    {
                        var dayName = nationalHoliday.FirstOrDefault(x => x.Date == i).HolidayName;
                        penaltyViewModel.HolidayDays.Add(i, dayName.ToString());
                        totalDay--;
                    }                   
                    else if (DayName == weekend2)
                    {
                        penaltyViewModel.HolidayDays.Add(i, weekend2);
                        totalDay--;
                    }
                    else if (DayName == weekend)
                    {
                        penaltyViewModel.HolidayDays.Add(i, weekend);
                        totalDay--;
                    }
                }
            }
            else
            {

            }
            penaltyViewModel.CalculationDay = totalDay;
            if (totalDay>=11)
            {
               int day= totalDay - 10;
                penaltyViewModel.Amercement = day * 5;
            }
            else
            {
                penaltyViewModel.Amercement = 0;
            }
            penaltyViewModel.Currency = Currency;
            return penaltyViewModel;
        }       
    }
}
