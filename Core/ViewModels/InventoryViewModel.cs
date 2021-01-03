using ConsoleDiablo.App.Entities.Contracts.ViewModels;
using ConsoleDiablo.App.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Core.ViewModels
{
    public class InventoryViewModel : IInventoryViewModel
    {
        public InventoryViewModel(Item[] inventory, double moneyBalance)
        {
            this.Inventory = inventory;
            this.MoneyBalance = moneyBalance;
        }
        public Item[] Inventory { get; }

        public double MoneyBalance { get; }
    }
}
