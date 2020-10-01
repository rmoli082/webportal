using System.Web.Http;

namespace TimeCard.API.Configuration
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{category}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
