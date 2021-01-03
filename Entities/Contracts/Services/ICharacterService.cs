using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts.Services
{
    public interface ICharacterService
    {
        string CreateNewCharacter(IList<string> args);

        ICharacter ChooseCharacter(string characterName);

        void DeleteCharacter(IList<string> args);
    }
}
