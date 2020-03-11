using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Application.Interfaces;
using T2MWeather.Domain.Interfaces;
using T2MWeather.Domain.Models;

namespace T2MWeather.Application.Services
{
    public class ServiceCity: IServiceCity
    {
        private ICityRepository _cityRepository;

        public void DeleteCity(string name)
        {
            _cityRepository.DeleteCity(name);
        }

        public IEnumerable<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public City GetTemperatures(string city)
        {
            return _cityRepository.GetTemperatures(city);
        }

        public void PostCity(string name)
        {
            _cityRepository.PostCity(name);
        }
    }
}
