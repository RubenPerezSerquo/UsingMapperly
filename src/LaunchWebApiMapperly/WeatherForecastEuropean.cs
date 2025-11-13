namespace LaunchWebApiMapperly
{
    public class WeatherForecastEuropean
    {
        public DateOnly Date { get; }
        public int TemperatureC { get; }
        public string? Summary { get; }

        public WeatherForecastEuropean(DateOnly date, int temperatureC, string? summary)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }
    }
}
