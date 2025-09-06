using System;

namespace OfficeAutomation.Domain.Entities
{
    public class City
    {
        private string _cityName;

        public City(string cityName)
        {
            SetCityName(cityName);
        }

        public int IdCity { get; private set; }
        public string CityName => _cityName;

        public void SetCityName(string cityName)
        {
            if (string.IsNullOrWhiteSpace(cityName))
                throw new ArgumentException("CityName is required.");
            if (cityName.Length > 50)
                throw new ArgumentException("CityName cannot exceed 50 characters.");

            _cityName = cityName;
        }
    }
}