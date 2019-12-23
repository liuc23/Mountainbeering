﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Weather.Models;
using Weather.Models.Response;

namespace Weather.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(ILogger<WeatherController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherResponse> Get()
        {
            return new List<WeatherResponse> {
                new WeatherResponse()
                {
                    Coord = new Coord()
                    {
                        Lon = 139,
                        Lat = 35
                    }
                }
            };
        }
    }
}
