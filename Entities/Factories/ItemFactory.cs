using ConsoleDiablo.App.Entities.Contracts.Models;
using ConsoleDiablo.App.Entities.Gears;
using ConsoleDiablo.App.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleDiablo.App.Entities.Items.Factory
{
    public class ItemFactory
    {
        public Item CreateItem(string type, string name)
        {
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

                var item = (Item)Activator.CreateInstance(itemType, name);

                return item;
            }
        }
    }
}
