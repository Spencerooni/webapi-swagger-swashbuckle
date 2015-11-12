using WebApplicationApiClient;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Activities client = new Activities(new WebApiApplication());
        }
    }
}