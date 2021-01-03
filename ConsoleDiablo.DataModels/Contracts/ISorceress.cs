using ConsoleDiablo.DataModels.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts
{
    public interface ISorceress : ICharacter
    {
        void UseSorceressAbility(Character character, SorceressAbility sorcAbility);
    }
}
