using Spectre.Console.Cli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKDAgility.ConfigDemo.CLI.Commands
{
    public class DefaultCommand : AsyncCommand<DefaultCommandSettings>
    {
        public override Task<int> ExecuteAsync(CommandContext context, DefaultCommandSettings settings)
        {
            Console.WriteLine("Hello, World!");
            return Task.FromResult(0);
        }
    }
}
