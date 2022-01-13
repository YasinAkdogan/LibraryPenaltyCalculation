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
    public class NationalHolidaySeed : IEntityTypeConfiguration<NationalHoliday>
    {
        private readonly int[] _ids;
        public NationalHolidaySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<NationalHoliday> builder)
        {
            builder.HasData(
                         new NationalHoliday { Id = 1, HolidayName = "Yılbaşı", Date = Convert.ToDateTime("01.01.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 2, HolidayName = "Ulusal Egemenlik ve Çocuk Bayramı", Date = Convert.ToDateTime("23.04.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 3, HolidayName = "Emek ve Dayanışma Günü", Date = Convert.ToDateTime("01.05.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 4, HolidayName = "Ramazan Bayramı", Date = Convert.ToDateTime("02.05.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 5, HolidayName = "Ramazan Bayramı", Date = Convert.ToDateTime("03.05.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 6, HolidayName = "Ramazan Bayramı", Date = Convert.ToDateTime("04.05.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 7, HolidayName = "Atatürk'ü Anma, Gençlik ve Spor Bayramı", Date = Convert.ToDateTime("19.05.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 8, HolidayName = "Kurban Bayramı", Date = Convert.ToDateTime("09.07.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 9, HolidayName = "Kurban Bayramı", Date = Convert.ToDateTime("10.07.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 10, HolidayName = "Kurban Bayramı", Date = Convert.ToDateTime("11.07.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 11, HolidayName = "Kurban Bayramı", Date = Convert.ToDateTime("12.07.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 12, HolidayName = "Demokrasi Bayramı", Date = Convert.ToDateTime("15.07.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 13, HolidayName = "Zafer Bayramı", Date = Convert.ToDateTime("30.08.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 14, HolidayName = "Cumhuriyet Bayramı", Date = Convert.ToDateTime("29.10.2022"), CountryId = _ids[0] },
                         new NationalHoliday { Id = 15, HolidayName = "Yılbaşı", Date = Convert.ToDateTime("01.01.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 17, HolidayName = "Peygamberin Yükselişi", Date = Convert.ToDateTime("01.03.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 18, HolidayName = "Mart Ekinoksu", Date = Convert.ToDateTime("20.03.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 19, HolidayName = "Ramazan Bayramı", Date = Convert.ToDateTime("02.05.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 20, HolidayName = "Ramazan Bayramı", Date = Convert.ToDateTime("03.05.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 21, HolidayName = "Ramazan Bayramı", Date = Convert.ToDateTime("04.05.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 22, HolidayName = "Kurban Bayramı", Date = Convert.ToDateTime("09.07.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 23, HolidayName = "Kurban Bayramı", Date = Convert.ToDateTime("10.07.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 24, HolidayName = "Kurban Bayramı", Date = Convert.ToDateTime("11.07.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 25, HolidayName = "Kurban Bayramı", Date = Convert.ToDateTime("12.07.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 26, HolidayName = "Hac Mevsimi Başlıyor", Date = Convert.ToDateTime("01.07.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 27, HolidayName = "Eylül Ekinoksu", Date = Convert.ToDateTime("23.09.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 28, HolidayName = "Anma Günü", Date = Convert.ToDateTime("01.12.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 29, HolidayName = "Ulusal Günü", Date = Convert.ToDateTime("02.12.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 30, HolidayName = "Aralık Gün Dönümü", Date = Convert.ToDateTime("22.12.2022"), CountryId = _ids[1] },
                         new NationalHoliday { Id = 31, HolidayName = "Yılbaşı", Date = Convert.ToDateTime("01.01.2022"), CountryId = _ids[2] },
                         new NationalHoliday { Id = 32, HolidayName = "Noel", Date = Convert.ToDateTime("25.12.2022"), CountryId = _ids[2] },
                         new NationalHoliday { Id = 33, HolidayName = "Şükran Günü", Date = Convert.ToDateTime("24.11.2022"), CountryId = _ids[2] },
                         new NationalHoliday { Id = 34, HolidayName = "Ulusal Bağımsızlık günü", Date = Convert.ToDateTime("04.07.2022"), CountryId = _ids[2] },
                         new NationalHoliday { Id = 35, HolidayName = "Martin Luther King Günü", Date = Convert.ToDateTime("16.06.2022"), CountryId = _ids[2] },
                         new NationalHoliday { Id = 36, HolidayName = "Başkan’nın Günü", Date = Convert.ToDateTime("21.02.2022"), CountryId = _ids[2] },
                         new NationalHoliday { Id = 37, HolidayName = "Şehitler Günü", Date = Convert.ToDateTime("23.05.2022"), CountryId = _ids[2] },
                         new NationalHoliday { Id = 38, HolidayName = "İşçi Bayramı", Date = Convert.ToDateTime("05.09.2022"), CountryId = _ids[2] },
                         new NationalHoliday { Id = 39, HolidayName = "Colombus Günü", Date = Convert.ToDateTime("10.10.2022"), CountryId = _ids[2] },
                         new NationalHoliday { Id = 40, HolidayName = "Veterans (Armistice) Günü", Date = Convert.ToDateTime("11.11.2022"), CountryId = _ids[2] }
               );
        }
    }
}
