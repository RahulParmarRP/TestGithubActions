using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestGithubActions.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm","Hot", "Sweltering"
        };

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
        }

        [HttpGet]
        [Route("add/{a}/{b}")]
        public IActionResult Add(int a, int b)
        {
            return Ok(a + b);
        }

        [HttpGet]
        [Route("hellothere")]
        public IActionResult Hello()
        {
            return Ok("hello world!");
        }
    }
}
