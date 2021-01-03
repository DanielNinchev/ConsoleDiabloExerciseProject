using ConsoleDiablo.App.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Gears
{
    public class DruidGear : CharacterGear
    {
        public DruidGear(int capacity, ItemDesignedForCharacter allowedItems) : base(capacity, allowedItems)
        {
        }
    }
}
