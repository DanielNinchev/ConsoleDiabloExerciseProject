using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts.Models
{
    public interface IWeapon : IItem
    {
        double StrengthBonus { get; }
        double DexterityBonus { get; }
        double EnergyBonus { get; }
    }
}
