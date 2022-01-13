using LibraryPenaltyCalculation.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Data.Seeds
{
    public class CountrySeed : IEntityTypeConfiguration<Country>
    {
        private readonly int[] _ids;
        public CountrySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { Id = _ids[0], Name = "Turkey", Currency = "₺", Weekend = "Saturday", Weekend2 = "Sunday" },
                  new Country { Id = _ids[1], Name = "Dubai", Currency = "د.إ", Weekend = "Friday", Weekend2 = "Saturday" },
                    new Country { Id = _ids[2], Name = "United States", Currency = "$", Weekend = "Saturday", Weekend2 = "Sunday" }
                );
        }
    }
}
