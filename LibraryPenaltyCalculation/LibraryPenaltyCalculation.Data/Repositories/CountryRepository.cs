using LibraryPenaltyCalculation.Core.Models;
using LibraryPenaltyCalculation.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Data.Repositories
{
   public class CountryRepository : Repository<Country>, ICountryRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CountryRepository(AppDbContext context) : base(context)
        {

        }
    }
}
