using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts.Models
{
    public interface IItem
    {
        double SellValue { get; }
        int InventoryLoad { get; }
        double DroppingFrequency { get; }
        string Name { get; }
    }
}
