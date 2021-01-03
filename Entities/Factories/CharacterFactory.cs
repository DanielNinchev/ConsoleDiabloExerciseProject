using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.DataModels.Characters;
using System;
using System.Linq;
using System.Reflection;

namespace ConsoleDiablo.App.Entities.Characters.Factory
{
    public class CharacterFactory
    {
        public static Character CreateCharacter(string type, string name)
        {
            var characterType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == type);

            if (characterType == null)
            {
                throw new InvalidOperationException("Invalid character type \"{type}\"!");
            }

            if (!typeof(ICharacter).IsAssignableFrom(characterType))
            {
                throw new InvalidFilterCriteriaException($"{characterType} is not а character!");
            }

            var character = (Character)Activator.CreateInstance(characterType, name);

            return character;
        }
    }
}
