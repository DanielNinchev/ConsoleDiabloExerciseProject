using ConsoleDiablo.App.Entities.Contracts.Models;
using ConsoleDiablo.App.Entities.Weapons;
using ConsoleDiablo.DataModels.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleDiablo.App.Entities.Gears
{
    public abstract class CharacterGear
    {

        private  List<Item> gear;

        protected CharacterGear()
        {
            this.gear = new List<Item>();
        }

        public void PutItemOn(string type, string name, Character character)
        {
            var itemType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(it => it.Name == type);

            if (itemType == null)
            {
                throw new ArgumentNullException("The item cannot be null!");
            }

            if (!typeof(IItem).IsAssignableFrom(itemType))
            {
                throw new ArgumentException($"{itemType} is not an item!");
            }

            if (this.gear.Contains(itemType))
            {
                throw new InvalidOperationException("This character cannot carry anymore!");
            }

            this.gear.Add(item);
        }

        private void EnsureItemExists(string name)
        {
            if (!this.gear.Any())
            {
                throw new InvalidOperationException("This character has not picked any items yet.");
            }

            var itemExists = this.gear.Any(i => i.GetType().Name == name);

            if (!itemExists)
            {
                throw new ArgumentException($"There is no {name} in this gear!");
            }
        }

        public Item ChooseItemFromGear(string name)
        {
            EnsureItemExists(name);

            var chosenItem = this.gear.First(i => i.GetType().Name == name);

            return chosenItem;
        }

    }
}
