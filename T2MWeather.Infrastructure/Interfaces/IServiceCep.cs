using System;
using System.Collections.Generic;
using System.Text;

namespace T2MWeather.Infrastructure.Interfaces
{
    public interface IServiceCep
    {
        System.Threading.Tasks.Task<string> GetNameCityAsync(string cep);
    }
}
