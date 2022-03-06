using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        public async static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var c = new Class1();

            // List<string> list = new List<string>();

            var websiteUrl = args[0];
            Console.WriteLine(websiteUrl);

            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(websiteUrl);
            Console.WriteLine(response);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(response);

            var regex = new Regex(@"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+");

            var matchCollection = regex.Matches(content);

            var set = new HashSet<string>();

            foreach (var item in matchCollection)
            {
                set.Add(item.ToString());
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }


        }
    }
}
