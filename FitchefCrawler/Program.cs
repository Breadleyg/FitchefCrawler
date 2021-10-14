using System.Threading.Tasks;

namespace FitchefCrawler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }

        private static async Task MainAsync(string[] args)
        {
            var crawler = new FitchefCrawler<Recipe>();

            await crawler.Crawl();
        }
    }
}