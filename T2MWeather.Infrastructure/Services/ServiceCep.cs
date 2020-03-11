using System;
using System.Collections.Generic;
using System.Text;
using T2MWeather.Infrastructure.Interfaces;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json.Linq;

namespace T2MWeather.Infrastructure.Services
{
    public class ServiceCep : IServiceCep
    {
        public async System.Threading.Tasks.Task<string> GetNameCityAsync(string cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                return json.SelectToken("localidade").ToString();
            }

            return null;
        }
    }
}
