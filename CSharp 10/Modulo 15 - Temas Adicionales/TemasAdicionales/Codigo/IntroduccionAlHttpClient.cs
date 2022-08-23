using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales.Codigo
{
    internal class IntroduccionAlHttpClient
    {
        public async Task CodigoDelCurso()
        {
            var httpClient = new HttpClient();

            // Ejemplo 1: Usando GetAsync
            var respuesta = await httpClient.GetAsync("https://localhost:7169/WeatherForecast");
            var cuerpo = await respuesta.Content.ReadAsStringAsync();

            Console.WriteLine("--cuerpo--");
            Console.WriteLine(cuerpo);

            Console.WriteLine("--cabecera--");

            foreach (var cabecera in respuesta.Headers)
            {
                Console.WriteLine($"{cabecera.Key}: {cabecera.Value.First()}");
            }

            Console.WriteLine("--código de estatus--");
            Console.WriteLine(respuesta.StatusCode);
            Console.WriteLine(respuesta.IsSuccessStatusCode);

            // Ejemplo 2: Usando GetStringAsync

            var respuestaString = await httpClient.GetStringAsync("https://localhost:7169/WeatherForecast");
            Console.WriteLine(respuestaString);

            // Ejemplo 3: Acción específica por Código de Estatus

            switch (respuesta.StatusCode)
            {
                case System.Net.HttpStatusCode.Continue:
                    break;
                case System.Net.HttpStatusCode.SwitchingProtocols:
                    break;
                case System.Net.HttpStatusCode.Processing:
                    break;
                case System.Net.HttpStatusCode.EarlyHints:
                    break;
                case System.Net.HttpStatusCode.OK:
                    break;
                case System.Net.HttpStatusCode.Created:
                    break;
                case System.Net.HttpStatusCode.Accepted:
                    break;
                case System.Net.HttpStatusCode.NonAuthoritativeInformation:
                    break;
                case System.Net.HttpStatusCode.NoContent:
                    break;
                case System.Net.HttpStatusCode.ResetContent:
                    break;
                case System.Net.HttpStatusCode.PartialContent:
                    break;
                case System.Net.HttpStatusCode.MultiStatus:
                    break;
                case System.Net.HttpStatusCode.AlreadyReported:
                    break;
                case System.Net.HttpStatusCode.IMUsed:
                    break;
                case System.Net.HttpStatusCode.Ambiguous:
                    break;
                case System.Net.HttpStatusCode.Moved:
                    break;
                case System.Net.HttpStatusCode.Found:
                    break;
                case System.Net.HttpStatusCode.RedirectMethod:
                    break;
                case System.Net.HttpStatusCode.NotModified:
                    break;
                case System.Net.HttpStatusCode.UseProxy:
                    break;
                case System.Net.HttpStatusCode.Unused:
                    break;
                case System.Net.HttpStatusCode.RedirectKeepVerb:
                    break;
                case System.Net.HttpStatusCode.PermanentRedirect:
                    break;
                case System.Net.HttpStatusCode.BadRequest:
                    break;
                case System.Net.HttpStatusCode.Unauthorized:
                    break;
                case System.Net.HttpStatusCode.PaymentRequired:
                    break;
                case System.Net.HttpStatusCode.Forbidden:
                    break;
                case System.Net.HttpStatusCode.NotFound:
                    break;
                case System.Net.HttpStatusCode.MethodNotAllowed:
                    break;
                case System.Net.HttpStatusCode.NotAcceptable:
                    break;
                case System.Net.HttpStatusCode.ProxyAuthenticationRequired:
                    break;
                case System.Net.HttpStatusCode.RequestTimeout:
                    break;
                case System.Net.HttpStatusCode.Conflict:
                    break;
                case System.Net.HttpStatusCode.Gone:
                    break;
                case System.Net.HttpStatusCode.LengthRequired:
                    break;
                case System.Net.HttpStatusCode.PreconditionFailed:
                    break;
                case System.Net.HttpStatusCode.RequestEntityTooLarge:
                    break;
                case System.Net.HttpStatusCode.RequestUriTooLong:
                    break;
                case System.Net.HttpStatusCode.UnsupportedMediaType:
                    break;
                case System.Net.HttpStatusCode.RequestedRangeNotSatisfiable:
                    break;
                case System.Net.HttpStatusCode.ExpectationFailed:
                    break;
                case System.Net.HttpStatusCode.MisdirectedRequest:
                    break;
                case System.Net.HttpStatusCode.UnprocessableEntity:
                    break;
                case System.Net.HttpStatusCode.Locked:
                    break;
                case System.Net.HttpStatusCode.FailedDependency:
                    break;
                case System.Net.HttpStatusCode.UpgradeRequired:
                    break;
                case System.Net.HttpStatusCode.PreconditionRequired:
                    break;
                case System.Net.HttpStatusCode.TooManyRequests:
                    break;
                case System.Net.HttpStatusCode.RequestHeaderFieldsTooLarge:
                    break;
                case System.Net.HttpStatusCode.UnavailableForLegalReasons:
                    break;
                case System.Net.HttpStatusCode.InternalServerError:
                    break;
                case System.Net.HttpStatusCode.NotImplemented:
                    break;
                case System.Net.HttpStatusCode.BadGateway:
                    break;
                case System.Net.HttpStatusCode.ServiceUnavailable:
                    break;
                case System.Net.HttpStatusCode.GatewayTimeout:
                    break;
                case System.Net.HttpStatusCode.HttpVersionNotSupported:
                    break;
                case System.Net.HttpStatusCode.VariantAlsoNegotiates:
                    break;
                case System.Net.HttpStatusCode.InsufficientStorage:
                    break;
                case System.Net.HttpStatusCode.LoopDetected:
                    break;
                case System.Net.HttpStatusCode.NotExtended:
                    break;
                case System.Net.HttpStatusCode.NetworkAuthenticationRequired:
                    break;
            }
        }
    }
}
