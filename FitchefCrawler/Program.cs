using System.Threading.Tasks;
using FitchefCrawler.Data.Models;
using FitchefCrawler.Core;

namespace FitchefCrawler.Crawler
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

            await crawler.CrawlAsync();
        }
    }
}