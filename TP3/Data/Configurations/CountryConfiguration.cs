using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { Id = 1, CountryCode = "BR", CountryName = "Brazil" },
                new Country { Id = 2, CountryCode = "US", CountryName = "United States" },
                new Country { Id = 3, CountryCode = "FR", CountryName = "France" }
            );
        }
    }
}
