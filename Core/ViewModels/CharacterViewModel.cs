using ConsoleDiablo.App.Entities.Contracts.ViewModels;
using ConsoleDiablo.App.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Core.ViewModels
{
    public class CharacterViewModel : ICharacterViewModel
    {
        public CharacterViewModel(string name, string type, int level, Item[] gear, Item[] inventory, Item[] stash)
        {
            this.Name = name;
            this.Type = type;
            this.Level = level;
            this.Gear = gear;
            this.Inventory = inventory;
            this.Stash = stash;
        }

        public string Name { get; }

        public string Type { get; }

        public int Level { get; }

        public Item[] Gear { get; }

        public Item[] Inventory { get; }

        public Item[] Stash { get; }
    }
}
