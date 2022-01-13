using LibraryPenaltyCalculation.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Data.Configurations
{
    public class NationalHolidayConfiguration : IEntityTypeConfiguration<NationalHoliday>
    {
        public void Configure(EntityTypeBuilder<NationalHoliday> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.HolidayName).IsRequired().HasMaxLength(400);
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.CountryId).IsRequired();
        }
    }
}
