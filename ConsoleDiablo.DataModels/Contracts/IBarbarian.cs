using ConsoleDiablo.DataModels.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts
{
    public interface IBarbarian : ICharacter
    {
        void UseBarbarianAbility(Character character, BarbarianAbility barbAbility);
    }
}
