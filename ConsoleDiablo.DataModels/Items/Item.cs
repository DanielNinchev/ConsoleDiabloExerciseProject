using ConsoleDiablo.App.Entities.Contracts.Models;
using ConsoleDiablo.DataModels.Characters;
using System;
using System.Collections.Generic;

namespace ConsoleDiablo.App.Entities.Weapons
{
    public abstract class Item : IItem
    {
        protected Item(string name, int inventoryLoad, double sellValue, double droppingFrequency)
        {
            Name = name;
            InventoryLoad = inventoryLoad;
            SellValue = sellValue;
            DroppingFrequency = droppingFrequency;
        }

        public double SellValue { get; set; }

        public int InventoryLoad { get; set; }

        public double DroppingFrequency { get; set; }

        public string Name { get; set; }

        public virtual void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action.");
            }
        }
    }
}
