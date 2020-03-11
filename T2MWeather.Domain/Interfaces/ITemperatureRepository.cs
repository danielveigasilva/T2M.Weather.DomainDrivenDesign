using System;
using System.Collections.Generic;
using System.Text;

namespace T2MWeather.Domain.Interfaces
{
    public interface ITemperatureRepository
    {
        void DeleteTemperatures(string name);
    }
}
