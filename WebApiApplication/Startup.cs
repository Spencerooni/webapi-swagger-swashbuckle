using System.Web.Http;
using Owin;

namespace WebApiApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            SwaggerConfig.Register(config);

            app.UseWebApi(config);
        }
    }
}