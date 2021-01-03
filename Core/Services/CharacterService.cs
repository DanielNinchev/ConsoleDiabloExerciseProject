using ConsoleDiablo.App.Core.IO;
using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.App.Entities.Contracts.Models;
using ConsoleDiablo.App.Entities.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleDiablo.App.Core
{
    public class CharacterService : ICharacterService
    {
        private List<ICharacter> characters;
        private Type[] characterTypes;

        public CharacterService() : this(new List<ICharacter>(), new TypeCollector())
        {

        }

        public CharacterService(IEnumerable<ICharacter> characters, ITypeCollector typeCollector)
            : this(characters, typeCollector.GetAllInheritingTypes<ICharacter>())
        {

        }

        public CharacterService(IEnumerable<ICharacter> characters, Type[] characterTypes)
        {
            this.characters = characters.ToList();
            this.characterTypes = characterTypes;
        }

        public ICharacter ChooseCharacter(string characterName)
        {
            ICharacter character = characters.FirstOrDefault(h => h.Name.Equals(characterName, StringComparison.OrdinalIgnoreCase));

            if (character == null)
            {
                throw new ArgumentException(string.Format(Constants.InvalidCharacterMessage, characterName));
            }

            return character;
        }

        public string CreateNewCharacter(IList<string> args)
        {
            string characterName = args[0];
            string characterType = args[1];

            Type typeOfCharacter = this.characterTypes.FirstOrDefault(t => t.Name.Equals(characterType, StringComparison.OrdinalIgnoreCase));

            if (typeOfCharacter == null)
            {
                throw new ArgumentException($"Character {characterType} does not exist!");
            }

            ICharacter characterInstance = (ICharacter)Activator.CreateInstance(typeOfCharacter, characterName);

            this.characters.Add(characterInstance);

            return string.Format(Constants.CharacterCreatedMessage, characterType, characterName);
        }

        public void DeleteCharacter(IList<string> args)
        {
            throw new NotImplementedException();
        }
    }
}
