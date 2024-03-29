﻿using ConsoleDiablo.App.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities
{
    public class Battlecry : BarbarianAbility
    {
        private const int AttackPoints = 50;

        public Battlecry() : base(barbAbility: "Battlecry", manaCost:20)
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
