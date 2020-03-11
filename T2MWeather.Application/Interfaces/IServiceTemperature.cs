using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Domain.Models;

namespace T2MWeather.Application.Interfaces
{
    public interface IServiceTemperature
    {
        void DeleteTemperatures(string name);
    }
}
