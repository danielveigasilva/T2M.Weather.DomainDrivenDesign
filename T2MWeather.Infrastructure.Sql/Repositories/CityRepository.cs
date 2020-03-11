using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Domain.Interfaces;
using T2MWeather.Domain.Models;
using System.Data;

namespace T2MWeather.Infrastructure.Sql.Repositories
{
    public class CityRepository : ICityRepository
    {
        private IDbConnection _dbConnection; 
        public CityRepository(IDbConnection _dbConnection) 
        {
            this._dbConnection = _dbConnection;
        }

        public void DeleteCity(string name)
        {
            throw new NotImplementedException(); //SQL
        }

        public IEnumerable<City> GetAll()
        {
            throw new NotImplementedException(); //SQL
        }

        public City GetTemperatures(string city)
        {
            throw new NotImplementedException(); //SQL
        }

        public void PostCity(string name)
        {
            throw new NotImplementedException(); //SQL
        }

    }
}
