using ConsoleDiablo.App.Entities.Abilities.BarbarianAbilities;
using ConsoleDiablo.App.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities.SorceressAbilities
{
    public class Lightning : SorceressAbility
    {
        private const int AttackPoints = 200;

        public Lightning() : base(sorcAbility: "Lightning", manaCost: 140)
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
