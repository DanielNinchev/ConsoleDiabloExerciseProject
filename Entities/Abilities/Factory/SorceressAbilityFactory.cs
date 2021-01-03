using ConsoleDiablo.App.Entities.Abilities.BarbarianAbilities;
using ConsoleDiablo.App.Entities.Abilities.SorceressAbilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities.Factory
{
    public class SorceressAbilityFactory
    {
        public SorceressAbility CreateAbility(string name)
        {
            SorceressAbility ability;

            switch (name)
            {
                case "Blizzard":
                    ability = new Blizzard();
                    break;
                case "Lightning":
                    ability = new Lightning();
                    break;
                default:
                    throw new ArgumentException($"Invalid ability \"{name}\"");
            }

            return ability;
        }
    }
}
