using System;
using System.Collections.Generic;
using System.Text;

namespace T2MWeather.Infrastructure.Sql.Interfaces
{
    public interface IServiceTemperature
    {
        void DeleteTemperatures(string name);
    }
}
