﻿using ConsoleDiablo.App.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities
{
    public abstract class PaladinAbility
    {
        private string palAbility;

        protected PaladinAbility(string palAbility, int manaCost)
        {
            ManaCost = manaCost;
            PalAbility = palAbility;
        }

        public int ManaCost { get; }
        public string PalAbility
        {
            get { return palAbility; }
            set { palAbility = value; }
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
