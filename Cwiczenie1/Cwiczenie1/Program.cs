using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cwiczenie1
{
    class Program
    {
        //PascalCase - metoda z wielkiej
        //string z małej
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var result = await client.GetAsync("https://www.pjatk.edu.pl");

            if (result.IsSuccessStatusCode) //kod 2xx
            {
                var html = await result.Content.ReadAsStringAsync();


            }

            Console.WriteLine("Hello World!");
        }
    }
}
