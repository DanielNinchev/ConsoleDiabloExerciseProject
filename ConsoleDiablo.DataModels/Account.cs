using System;
using System.Collections.Generic;

namespace ConsoleDiablo.DataModels
{
    public class Account
    {
        public Account()
        {
            this.Characters = new List<int>();
        }

        public Account(int id, string accountName, string password) : this()
        {
            this.Id = id;
            this.AccountName = accountName;
            this.Password = password;
        }

        public Account(int id, string accountName, string password, IEnumerable<int> characters)
            :this(id, accountName, password)
        {
            this.Characters.AddRange(new List<int>(characters));
        }

        public List<int> Characters { get; set; } = new List<int>();
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
    }
}
