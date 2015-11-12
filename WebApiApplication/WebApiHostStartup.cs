using System.Web.Http;
using Owin;

namespace WebApiApplication
{
    public class WebApiHostStartup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            SwaggerConfig.RegisterWithConfig(config);

            app.UseWebApi(config);
        }
    }
}