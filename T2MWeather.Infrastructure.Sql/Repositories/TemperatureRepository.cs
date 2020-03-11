using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Domain.Interfaces;
using System.Data;

namespace T2MWeather.Infrastructure.Sql.Repositories
{
    public class TemperatureRepository : ITemperatureRepository
    {
        private IDbConnection _dbConnection;
        public TemperatureRepository(IDbConnection _dbConnection)
        {
            this._dbConnection = _dbConnection;
        }

        public void DeleteTemperatures(string name)
        {
            throw new NotImplementedException(); //SQL
        }
    }
}
