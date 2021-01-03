using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts
{
    public interface ICharacter
    {
        string Name { get; }
        double Strength { get; }
        double Damage { get; }
        double Dexterity { get; }
        double Defense { get; }
        double Vitality { get; }
        double Life { get; }
        double BaseLife { get; }
        double LifeRegenerationMultiplier { get; }
        double Energy { get; }
        double Mana { get; }
        double BaseMana { get; }
        double ManaRegenerationMultiplier { get; }
        double Experience { get; }
        int Level { get; }
        double FireResistance { get; }
        double LightningResistance { get; }
        double ColdResistance { get; }
        double PoisonResistance { get; }
        double MoneyBalance { get; }
        CharacterGear Gear { get; }
    }
}
