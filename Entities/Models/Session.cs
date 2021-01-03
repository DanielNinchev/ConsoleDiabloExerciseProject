using ConsoleDiablo.DataModels;
using ConsoleDiablo.App.Entities.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleDiablo.App.Entities.Models
{
    public class Session : ISession
    {
        private Account account;
        private Stack<IMenu> history;

        public Session()
        {
            history = new Stack<IMenu>();
        }

        public string AccountName => this.account?.AccountName;

        public int AccountId => this.account?.Id ?? 0;

        public bool IsLoggedIn => this.account != null;

        public IMenu CurrentMenu => this.history.Peek();

        public IMenu Back()
        {
            if (history.Count > 1)
            {
                this.history.Pop();
            }

            IMenu menu = this.history.Peek();
            menu.Open();

            return menu;
        }

        public void LogIn(Account account)
        {
            this.account = account;
        }

        public void LogOut()
        {
            this.account = null;
        }

        public bool PushView(IMenu view)
        {
            if (!this.history.Any() || this.history.Peek() != view)
            {
                this.history.Push(view);

                return true;
            }

            return false;
        }

        public void Reset()
        {
            this.account = null;
            this.history = new Stack<IMenu>();
        }
    }
}
