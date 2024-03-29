﻿using ConsoleDiablo.App.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities
{
    public abstract class BarbarianAbility
    {
        private string barbAbility;

        protected BarbarianAbility(string barbAbility, int manaCost)
        {
            ManaCost = manaCost;
            BarbAbility = barbAbility;
        }

        public int ManaCost { get; }
        public string BarbAbility
        {
            get { return barbAbility; }
            set { barbAbility = value; }
        }

        public virtual void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action.");
            }
        }
    }
}
