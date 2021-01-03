using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.DataModels.Characters;
using System;

namespace ConsoleDiablo.App.Entities.Characters
{
    public class Barbarian : Character, IBarbarian
    {
        public Barbarian(string name) : base 
            (name, 
            strength: 25,
            dexterity: 15,
            vitality: 20,
            energy: 5,
            gear: new BarbarianGear())        
        {

        }

        public void UseBarbarianAbility(Character character, BarbarianAbility barbAbility)
        {
            EnsureAlive();

            if (barbAbility is Battlecry & character.Mana >= barbAbility.ManaCost)
            {
                barbAbility.AffectCharacter(character);
            }
            else if (barbAbility is Ferocity & character.Mana >= barbAbility.ManaCost)
            {
                barbAbility.AffectCharacter(character);
            }
            else
            {
                throw new ArgumentException($"{character.Name} does not have enough mana to perform this action.");
            }
        }
    }
}
