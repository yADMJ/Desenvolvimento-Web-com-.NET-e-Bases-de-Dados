﻿namespace CityBreaks.Web.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }            
        public Country Country { get; set; }

        public List<Property> Properties { get; set; } = new();

    }
}
