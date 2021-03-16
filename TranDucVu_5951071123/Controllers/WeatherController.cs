using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TranDucVu_5951071123.Controllers
{
    public class WeatherController : ApiController
    {
        // GET api/weather
        public IEnumerable<WeatherInfo> Get()
        {
            var WeatherInfList = new List<WeatherInfo>();
            for (int i = 0; i < 10; i++)
            {
                var WeatherInfo = new WeatherInfo
                {
                    Location = $"Location {i}",
                    Degree = i * 23 / 17,
                    Datetime = DateTime.Now.ToUniversalTime()
                };
                WeatherInfList.Add(WeatherInfo);
            }
            return WeatherInfList;
        }

        // GET: api/Weather/5
        public WeatherInfo Get(int id)
        {
            return new WeatherInfo
            {
                Location = $"Location {id}",
                Degree = id * 23 / 17,
                Datetime = DateTime.Now.ToUniversalTime()
            }; ;
        }
    }

}

