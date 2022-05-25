namespace HackathonWeb.Models
{
    public class HomeViewModel
    {
        public string Weather { get; set; }
        public string Input { get; set; }
        public string ReversedString { get; set; }
        public IEnumerable<WeatherForecast> WeatherForecastList { get; set; }
    }
}
