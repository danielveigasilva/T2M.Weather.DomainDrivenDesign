using System;
using System.Collections.Generic;
using System.Text;

namespace T2MWeather.Application.Interfaces
{
    public interface IServiceCep
    {
        string GetNameCity(int cep);
    }
}
