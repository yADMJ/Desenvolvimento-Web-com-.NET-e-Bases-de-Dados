using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasData(
                new Property { Id = 1, Name = "Pousada Beira Mar", PricePerNight = 150.00m, CityId = 1 },
                new Property { Id = 2, Name = "Hotel Central Park", PricePerNight = 300.00m, CityId = 2 },
                new Property { Id = 3, Name = "Charming Apartment", PricePerNight = 200.00m, CityId = 3 }
            );
        }
    }
}
