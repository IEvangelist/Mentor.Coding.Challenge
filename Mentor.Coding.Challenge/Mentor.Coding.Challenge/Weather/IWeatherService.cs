using System.Threading.Tasks;

namespace Mentor.Coding.Challenge.Weather
{
    public interface IWeatherService
    {
        Task<CurrentWeather> GetCurrentWeatherAsync();
    }
}