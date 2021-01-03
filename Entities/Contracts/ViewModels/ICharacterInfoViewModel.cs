using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts.ViewModels
{
    public interface ICharacterInfoViewModel
    {
        int Id { get; }

        string Name { get; }

        string Type { get; }

        int Level { get; }
    }
}
