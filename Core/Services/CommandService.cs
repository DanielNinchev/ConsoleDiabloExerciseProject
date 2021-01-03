using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.App.Entities.Contracts.Models;
using ConsoleDiablo.App.Entities.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleDiablo.App.Core.Services
{
    public class CommandService :ICommandService
    {
        private ICharacterService characterService;
        private Type[] commandTypes;

        public CommandService(ICharacterService characterService) : this(characterService, new TypeCollector())
        {

        }

        public CommandService(ICharacterService characterService, ITypeCollector typeCollector)
            : this(characterService, typeCollector.GetAllInheritingTypes<ICommand>())
        {

        }

        public CommandService(ICharacterService characterService, Type[] allCommands)
        {
            this.characterService = characterService;
            this.commandTypes = allCommands;
        }

        public string ProcessCommand(string commandName, IList<string> commandArgs)
        {
            Type command = this.commandTypes.FirstOrDefault(ct => ct.Name.Equals(commandName, StringComparison.OrdinalIgnoreCase));

            if (command == null)
            {
                throw new ArgumentException($"Command {commandName} does not exist!");
            }

            ConstructorInfo ctor = command.GetConstructor(new Type[] { commandArgs.GetType(), this.characterService.GetType() });

            ICommand commandInstance = (ICommand)ctor.Invoke(new object[] { commandArgs, this.characterService });

            return commandInstance.Execute();
        }
    }
}
