﻿namespace Airline.core.AirlineEntities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string IsoCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}