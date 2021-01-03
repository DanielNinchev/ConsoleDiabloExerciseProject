using ConsoleDiablo.App.Entities.Contracts.ViewModels;
using ConsoleDiablo.App.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Core.ViewModels
{
    public class StashViewModel : IStashViewModel
    {
        public StashViewModel(Item[] stash, double moneyBalance)
        {
            this.Stash = stash;
            this.MoneyBalance = moneyBalance;
        }
        public Item[] Stash { get; }

        public double MoneyBalance { get; }
    }
}
