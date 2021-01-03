using ConsoleDiablo.DataModels.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts
{
    public interface IPaladin : ICharacter
    {
        void UsePaladinAbility(Character character, PaladinAbility palAbility);
    }
}
