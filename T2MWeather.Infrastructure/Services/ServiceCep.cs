using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Infrastructure.Interfaces;
using System.Net.Http;

namespace T2MWeather.Infrastructure.Services
{
    public class ServiceCep : IServiceCep
    {
        public string GetNameCity(int cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            HttpResponseMessage response = client.GetAsync("").Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ToString();
            }
            return null;
        }
    }
}
