using ConsoleDiablo.App.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities
{
    public class Zealotry : PaladinAbility
    {
        private const int AttackPoints = 80;

        public Zealotry() : base(palAbility: "Zealotry", manaCost: 30)
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
