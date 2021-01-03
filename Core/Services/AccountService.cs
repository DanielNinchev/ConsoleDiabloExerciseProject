using ConsoleDiablo.App.Entities.Contracts.Models;
using ConsoleDiablo.App.Entities.Contracts.Services;
using ConsoleDiablo.Data;
using ConsoleDiablo.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleDiablo.App.Core.Services
{
    public class AccountService : IAccountService
    {
        private ConsoleDiabloData gameData;
        private ISession session;

        public string GetAccount(int accountId)
        {
            var account = this.gameData.Accounts.FirstOrDefault(a => a.Id == accountId).AccountName;

            return account;
        }

        public Account GetAccountById(int accountId)
        {
            var account = this.gameData.Accounts.FirstOrDefault(a => a.Id == accountId);

            return account;
        }

        public bool TryCreatingAnAccount(string accountName, string password)
        {
            bool validAccountName = !string.IsNullOrEmpty(accountName) && accountName.Length > 3;
            bool validPassword = !string.IsNullOrEmpty(password) && password.Length > 3;

            if (!validAccountName || !validPassword)
            {
                throw new ArgumentException("The account name and the password must both be over 3 characters long!");
            }

            bool accountAlreadyExists = this.gameData.Accounts.Any(a => a.AccountName.Equals(accountName));

            if (accountAlreadyExists)
            {
                throw new ArgumentException("This account already exists!");
            }

            int accountId = this.gameData.Accounts.LastOrDefault()?.Id + 1 ?? 1;

            Account account = new Account(accountId, accountName, password);

            this.gameData.Accounts.Add(account);

            gameData.SaveChanges();

            this.TryLoggingIn(accountName, password);

            return true;
        }

        public bool TryLoggingIn(string accountName, string password)
        {
            if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            Account account = this.gameData.Accounts.FirstOrDefault(a => a.AccountName == accountName && a.Password == password);

            if (account == null)
            {
                return false;
            }

            this.session.Reset();
            this.session.LogIn(account);

            return true;
        }
    }
}
