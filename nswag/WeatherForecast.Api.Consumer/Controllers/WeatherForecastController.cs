using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Api.Client.Generated;

namespace WeatherForecast.Api.Consumer.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(IWeatherForecastClient weatherForecastClient) : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<Client.Generated.WeatherForecast>> Get()
    {
        var forecasts = await weatherForecastClient.GetAsync();
        return forecasts;
    }
}