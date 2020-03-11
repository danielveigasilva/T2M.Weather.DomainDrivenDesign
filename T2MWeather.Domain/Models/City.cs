using System;
using System.Collections.Generic;
using System.Text;

namespace T2MWeather.Domain.Models
{
    public class City
    {
        string city { get; set; }
        IEnumerable<Temperature> temperatures { get; set; } 
    }
}
