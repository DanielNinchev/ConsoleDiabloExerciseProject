﻿using ConsoleDiablo.App.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities.BarbarianAbilities
{
    public abstract class SorceressAbility
    {
        private string sorcAbility;

        protected SorceressAbility(string sorcAbility, int manaCost)
        {
            ManaCost = manaCost;
            SorcAbility = sorcAbility;
        }

        public int ManaCost { get; }
        public string SorcAbility
        {
            get { return sorcAbility; }
            set { sorcAbility = value; }
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
