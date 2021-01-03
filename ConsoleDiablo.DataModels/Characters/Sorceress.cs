using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.DataModels.Characters;
using System;

namespace ConsoleDiablo.App.Entities.Characters.Factory
{
    public class Sorceress : Character, ISorceress
    {
        public Sorceress(string name) : base
            (name,
            strength: 10,
            dexterity: 10,
            vitality: 10,
            energy: 35,
            gear: new SorceressGear())
        {

        }

        public void UseSorceressAbility(Character character, SorceressAbility sorcAbility)
        {
            EnsureAlive();
            if (sorcAbility is Blizzard & character.Mana >= sorcAbility.ManaCost)
            {
                sorcAbility.AffectCharacter(character);
            }
            else if (sorcAbility is Lightning & character.Mana >= sorcAbility.ManaCost)
            {
                sorcAbility.AffectCharacter(character);
            }
            else
            {
                throw new ArgumentException($"{character.Name} does not have enough mana to perform this action.");
            }
        }
    }
}
