using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Domain.Models;
    
namespace T2MWeather.Infrastructure.Sql.Interfaces
{
    public interface IServiceCity
    {
        City GetTemperatures(string city);
        IEnumerable<City> GetAll();
        void DeleteCity(string name);
        void PostCity(string name);
    }
}
