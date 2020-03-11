using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Application.Interfaces;
using T2MWeather.Domain.Interfaces;

namespace T2MWeather.Application.Services
{
    public class ServiceTemperature : IServiceTemperature
    {
        private ITemperatureRepository _temperatureRepository;
        public void DeleteTemperatures(string name)
        {
            _temperatureRepository.DeleteTemperatures(name);
        }
    }
}
