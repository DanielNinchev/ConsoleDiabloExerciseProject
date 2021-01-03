using ConsoleDiablo.App.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts.ViewModels
{
    public interface IInventoryViewModel
    {
        Item[] Inventory { get; }

        double MoneyBalance { get; }
    }
}
