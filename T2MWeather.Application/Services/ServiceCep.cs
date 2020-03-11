using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Application.Interfaces;

namespace T2MWeather.Application.Services
{
    public class ServiceCep : IServiceCep
    {
        public string GetNameCity(int cep)
        {
            return "city";
        }
    }
}
