using System;
using System.Threading.Tasks;

namespace Mentor.Coding.Challenge.Weather
{
    public class WeatherService : IWeatherService
    {
        Task<CurrentWeather> IWeatherService.GetCurrentWeatherAsync()
        {
            // TODO: implement this..

            throw new NotImplementedException();
        }
    }
}