using ConsoleDiablo.DataModels;
using ConsoleDiablo.DataModels.Characters;
using System.Collections.Generic;

namespace ConsoleDiablo.Data
{
    public class ConsoleDiabloData
    {
        public ConsoleDiabloData()
        {
            this.Accounts = DataMapper.LoadAccounts();
            this.Characters = DataMapper.LoadCharacters();
        }

        public List<Account> Accounts { get; set; }
        public List<Character> Characters { get; set; }

        public void SaveChanges()
        {
            DataMapper.SaveAccounts(this.Accounts);
            DataMapper.SaveCharacters(this.Characters);
        }
    }
}
