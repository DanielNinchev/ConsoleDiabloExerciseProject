using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.DataModels.Characters;
using System;

namespace ConsoleDiablo.App.Entities.Characters
{
    public class Paladin : Character, IPaladin
    {
        public Paladin(string name) : base
            (name,
            strength: 20,
            dexterity: 15,
            vitality: 20,
            energy: 10,
            gear: new PaladinGear())
        {

        }

        public void UsePaladinAbility(Character character, PaladinAbility palAbility)
        {
            EnsureAlive();

            if (palAbility is Zealotry & character.Mana >= palAbility.ManaCost)
            {
                palAbility.AffectCharacter(character);
            }
            else if (palAbility is Charge & character.Mana >= palAbility.ManaCost)
            {
                palAbility.AffectCharacter(character);
            }
            else
            {
                throw new ArgumentException($"{character.Name} does not have enough mana to perform this action.");
            }
        }
    }
}
