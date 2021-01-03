using ConsoleDiablo.App.Entities.Contracts.Models;
using ConsoleDiablo.DataModels.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Weapons
{
    public class Flail : Item, IWeapon
    { 
        public Flail() : base(name: "Flail", inventoryLoad: 6, sellValue: 500, requirements: null, droppingFrequency: 55)
        {

        }

        Random number = new Random();

        public double StrengthBonus => number.Next(7, 15);

        public double DexterityBonus => 0;

        public double EnergyBonus => 0;

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Strength += StrengthBonus;
        }
    }
}
