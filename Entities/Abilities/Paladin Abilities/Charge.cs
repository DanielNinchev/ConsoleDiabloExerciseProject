using ConsoleDiablo.App.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities
{
    public class Charge : PaladinAbility
    {
        private const int AttackPoints = 60;

        public Charge() : base(palAbility: "Charge", manaCost: 30)
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
