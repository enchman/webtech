using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;

namespace ServiceBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
            server.Run();
        }
    }
}