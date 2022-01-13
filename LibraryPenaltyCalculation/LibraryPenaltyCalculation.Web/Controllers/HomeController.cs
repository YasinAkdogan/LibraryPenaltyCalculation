using LibraryPenaltyCalculation.Business;
using LibraryPenaltyCalculation.Core.Businesses;
using LibraryPenaltyCalculation.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculationPenalty _calculationPenalty;
        private readonly ICountryBusiness _countryBusiness;
        private readonly INationalHolidayBusiness _nationalHolidayBusiness;
        public HomeController(ICalculationPenalty calculationPenalty,ICountryBusiness countryBusiness,INationalHolidayBusiness nationalHolidayBusiness)
        {
            _calculationPenalty = calculationPenalty;
            _countryBusiness = countryBusiness;
            _nationalHolidayBusiness = nationalHolidayBusiness;
        }
        public async Task<IActionResult> Index()
        {
            var countries = await _countryBusiness.GetAllAsync();
            return View(countries);
        }
        [HttpPost]
        public async Task<PartialViewResult> Penalties(DateTime GivenDate, DateTime TakenDate,int countryId)
        {
            var country = await _countryBusiness.GetByIdAsync(countryId);
            var nationalHoliday = await _nationalHolidayBusiness.Where(x => x.CountryId == countryId);
            CalculationViewModel model = new CalculationViewModel
            {
                GivenDate = GivenDate,
                TakenDate = TakenDate,
                CountryId = countryId
            };
            var penaltyViewModel = _calculationPenalty.CalculatePenalty(model,country.Weekend,country.Weekend2, nationalHoliday,country.Currency);
            return PartialView(penaltyViewModel);
        }
    }
}
