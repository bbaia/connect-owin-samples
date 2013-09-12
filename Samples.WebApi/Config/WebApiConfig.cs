using System.Web.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace Samples.WebApi.Config
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/"
            );

            // Configure JSON formatter
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter()
            {
                SerializerSettings = new JsonSerializerSettings()
                {
#if DEBUG
                    Formatting = Formatting.Indented
#endif
                }
            });
        }
    }
}
