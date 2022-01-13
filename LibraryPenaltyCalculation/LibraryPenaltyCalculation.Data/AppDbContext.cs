using LibraryPenaltyCalculation.Core.Models;
using LibraryPenaltyCalculation.Data.Configurations;
using LibraryPenaltyCalculation.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenaltyCalculation.Data
{
   public class AppDbContext:DbContext
    {        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<NationalHoliday> NationalHolidays { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfigurations());
            modelBuilder.ApplyConfiguration(new NationalHolidayConfiguration());
            modelBuilder.ApplyConfiguration(new CountrySeed(new int[] { 1, 2, 3 }));
            modelBuilder.ApplyConfiguration(new NationalHolidaySeed(new int[] { 1, 2,3 }));
        }
    }
}
