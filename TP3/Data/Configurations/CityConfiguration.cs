using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { Id = 1, Name = "São Paulo", CountryId = 1 },
                new City { Id = 2, Name = "New York", CountryId = 2 },
                new City { Id = 3, Name = "Paris", CountryId = 3 }
            );
        }
    }
}
