using ConsoleDiablo.DataModels.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts
{
    public interface IAmazon : ICharacter
    {
        void UseBarbarianAbility(Character character, AmazonAbility barbAbility);
    }
}
