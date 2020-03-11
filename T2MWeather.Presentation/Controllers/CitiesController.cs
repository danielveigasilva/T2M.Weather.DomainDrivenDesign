using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using T2MWeather.Application.Interfaces;

namespace T2MWeather.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IServiceCity _serviceCity;
        private readonly IServiceTemperature _serviceTemperature;
        private readonly IServiceCep _serviceCep;

        [HttpGet("{name}/temperatures")]
        public ActionResult GetTemperatures(string name)
        {
            return Ok(name);
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
        public ActionResult PostByCep(int cep)
        {
            try
            {
                //_serviceCity.PostCity(_serviceCep.GetNameCity(cep));
                return Ok(_serviceCep.GetNameCity(cep));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
