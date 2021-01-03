using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleDiablo.App.Entities.Abilities.Factory
{
    public class PaladinAbilityFactory
    {
        public PaladinAbility CreateAbility(string name)
        {
            var type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == name);

            if (type == null)
            {
                throw new ArgumentException($"Invalid ability \"{name}\"");
            }

            var item = (item)
        }
    }
}
