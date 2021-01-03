using ConsoleDiablo.App.Entities.Abilities.BarbarianAbilities;
using ConsoleDiablo.App.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities.SorceressAbilities
{
    public class Blizzard : SorceressAbility
    {
        private const int AttackPoints = 150;

        public Blizzard() : base(sorcAbility: "Blizzard", manaCost: 80)
        {

        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Damage += AttackPoints;
            character.Mana -= ManaCost;
        }
    }
}
