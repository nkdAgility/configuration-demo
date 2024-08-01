using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NKDAgility.ConfigDemo.CLI.Commands;
using Spectre.Console.Cli;
using Spectre.Console.Extensions.Hosting;
using Spectre.Console.Extensions.Hosting.Infrastructure;
using Spectre.Console.Extensions.Hosting.Worker;

namespace NKDAgility.ConfigDemo.CLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args);

            builder.ConfigureAppConfiguration(builder =>
            {
                builder.AddJsonFile("appsettings.json");
                builder.AddEnvironmentVariables();
                builder.AddCommandLine(args);
            });
            builder.UseSpectreConsole<DefaultCommand>(config =>
            {
                config.PropagateExceptions();
            });
            builder.UseConsoleLifetime();

            await builder.RunConsoleAsync();
        }
    }
}
