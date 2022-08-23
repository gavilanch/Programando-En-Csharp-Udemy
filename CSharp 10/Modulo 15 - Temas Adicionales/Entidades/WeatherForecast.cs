using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        [Range(-273, 60)]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required]
        public string Summary { get; set; } = null!;
    }
}