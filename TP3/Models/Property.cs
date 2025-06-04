﻿namespace CityBreaks.Web.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerNight { get; set; }

        public int CityId { get; set; }        
        public City City { get; set; }          
    }
}
