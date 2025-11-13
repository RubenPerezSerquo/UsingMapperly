using Riok.Mapperly.Abstractions;

namespace LaunchWebApiMapperly.Mapping
{
    [Mapper]
    public partial class WeatherForecastMapper
    {
        [MapperIgnoreSource(nameof(WeatherForecast.TemperatureF))]
        public partial WeatherForecastEuropean ToEuropean(WeatherForecast forecast);

        public partial List<WeatherForecastEuropean> ToEuropean(List<WeatherForecast> forecasts);
    }
}
