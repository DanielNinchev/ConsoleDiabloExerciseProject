using ConsoleDiablo.App.Entities.Characters;
using ConsoleDiablo.DataModels.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities
{
    public class Ferocity : BarbarianAbility
    {
            private const int AttackPoints = 100;

            public Ferocity() : base(barbAbility: "Ferocity", manaCost:40)
            {

            }

            //public override void AffectCharacter(Character character)
            //{
            //    base.AffectCharacter(character);
            //    character.Damage += AttackPoints;
            //    character.Mana -= ManaCost;
            //}

    }
}
