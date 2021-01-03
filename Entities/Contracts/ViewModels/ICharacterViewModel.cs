using ConsoleDiablo.App.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts.ViewModels
{
    public interface ICharacterViewModel
    {
        string Name { get; }

        string Type { get; }

        int Level { get; }

        Item[] Gear { get; }

        Item[] Inventory { get; }

        Item[] Stash { get; }
    }
}
