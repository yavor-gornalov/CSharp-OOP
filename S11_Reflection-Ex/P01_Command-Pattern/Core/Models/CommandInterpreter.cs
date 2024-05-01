using CommandPattern.Core.Contracts;
using System.Linq;
using System.Reflection;
using System;

namespace CommandPattern.Core.Models
{
    internal class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var commandTokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            //if (commandTokens.Length <= 1)
            //    throw new ArgumentException("Missing arguments!");

            var commandName = commandTokens[0];
            var commandArgs = commandTokens[1..];

            Type commandType = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == commandName + "Command");

            if (commandType == null)
                throw new InvalidOperationException("Invalid command!");

            ICommand command = Activator.CreateInstance(commandType) as ICommand;

            return command.Execute(commandArgs);
        }
    }
}
