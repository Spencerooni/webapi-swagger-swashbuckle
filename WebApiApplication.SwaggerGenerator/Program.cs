using System.IO;
using Microsoft.Owin.Testing;

namespace WebApiApplication.SwaggerGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var server = TestServer.Create<Startup>())
            {
                var response = server.CreateRequest("/swagger/docs/v1").GetAsync().Result;
                var content = response.Content.ReadAsStringAsync().Result;
                File.WriteAllText("swagger.json", content);
            }
        }
    }
}