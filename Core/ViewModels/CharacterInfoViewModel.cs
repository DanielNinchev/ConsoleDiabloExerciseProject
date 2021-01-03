using ConsoleDiablo.App.Entities.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Core.ViewModels
{
    public class CharacterInfoViewModel : ICharacterInfoViewModel
    {
        public CharacterInfoViewModel(int id, string name, string type, int level)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Level = level;
        }

        public int Id { get; }

        public string Name { get; }

        public string Type { get; }

        public int Level { get; }
    }
}
