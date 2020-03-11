using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Domain.Models;

namespace T2MWeather.Domain.Interfaces
{
    public interface ICityRepository
    {
        City GetTemperatures(string city);
        IEnumerable<City> GetAll();
        void DeleteCity(string name);
        void PostCity(string name);
    }
}
