using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using T2MWeather.Application.Interfaces;
using T2MWeather.Application.Services;
using T2MWeather.Infrastructure.Interfaces;
using T2MWeather.Infrastructure.Services;

namespace T2MWeather.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IServiceCity _serviceCity = new ServiceCity();
        private readonly IServiceTemperature _serviceTemperature = new ServiceTemperature();
        private readonly Infrastructure.Interfaces.IServiceCep _serviceCep = new Infrastructure.Services.ServiceCep();

        [HttpGet("{name}/temperatures")]
        public ActionResult GetTemperatures(string name)
        {
            try
            {
                return Ok(_serviceCity.GetTemperatures(name));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost("{name}")]
        public ActionResult PostCity(string name)
        {
            try
            {
                _serviceCity.PostCity(name);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete("{name}")]
        public ActionResult DeleteCity(string name)
        {
            try
            {
                _serviceCity.DeleteCity(name);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete("{name}/temperatures")]
        public ActionResult DeleteTemperatures(string name)
        {
            try
            {
                _serviceTemperature.DeleteTemperatures(name);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("temperatures")]
        public ActionResult GetAll()
        {
            try
            {
                _serviceCity.GetAll();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost("by_cep/{cep}")]
        public ActionResult PostByCep(string cep)
        {
            try
            {
                //_serviceCity.PostCity(_serviceCep.GetNameCity(cep));
                string t = _serviceCep.GetNameCityAsync(cep).Result;
                return Ok(t);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
