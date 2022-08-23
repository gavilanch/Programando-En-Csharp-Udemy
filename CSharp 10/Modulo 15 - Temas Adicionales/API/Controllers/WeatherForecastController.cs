using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWebHostEnvironment env;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IWebHostEnvironment env)
        {
            _logger = logger;
            this.env = env;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            HttpContext.Response.Headers.Add("ejemplo-respuesta", "El valor");

            //return BadRequest();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public ActionResult<int> Post(WeatherForecast weatherForecast)
        {
            Console.WriteLine(weatherForecast.Summary);
            return 1;
        }

        [HttpGet("mayusculas")]
        public ActionResult<string> GetMayusculas([FromHeader] 
        string? valorPersonalizado = "Soy Felipe")
        {
            Console.WriteLine(valorPersonalizado);
            return valorPersonalizado!.ToUpper();
        }

        [HttpPost("posteoArchivo")]
        public async Task<ActionResult> PostearArchivo([FromForm] IFormFile archivo)
        {
            var nombreArchivo = $"{Guid.NewGuid()}{Path.GetExtension(archivo.FileName)}";
            string folder = Path.Combine(env.WebRootPath, "carpeta");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string ruta = Path.Combine(folder, nombreArchivo);

            using (var fs = System.IO.File.Create(ruta))
            {
                await archivo.OpenReadStream().CopyToAsync(fs);
            }

            return Ok();
        }
    }
}