using ConsoleDiablo.App.Entities.Contracts.ViewModels;
using ConsoleDiablo.App.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Core.ViewModels
{
    public class GearViewModel : IGearViewModel
    {
        public GearViewModel(Item[] gear)
        {
            this.Gear = gear;
        }

        public Item[] Gear { get; }
    }
}
