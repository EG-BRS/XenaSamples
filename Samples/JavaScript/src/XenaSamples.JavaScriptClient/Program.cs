using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace JavaScriptClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Xena JavaScript Sample";

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
