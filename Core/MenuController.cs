using ConsoleDiablo.App.Entities.Contracts.Factories;
using ConsoleDiablo.App.Entities.Contracts.ViewModels;
using ConsoleDiablo.App.Entities.Menus;
using System;
using Microsoft.Extensions.DependencyInjection;
using ConsoleDiablo.App.Entities.Contracts.Models;

namespace ConsoleDiablo.App.Core
{
    internal class MenuController : IMainController
    {
        private IServiceProvider serviceProvider;
        private IGameViewEngine viewEngine;
        private ISession session;
        private ICommandFactory commandFactory;
        private ILabelFactory labelFactory;

        public MenuController(ILabelFactory labelFactory, IServiceProvider serviceProvider, IGameViewEngine viewEngine, ISession session, ICommandFactory commandFactory)
        {
            this.serviceProvider = serviceProvider;
            this.viewEngine = viewEngine;
            this.session = session;
            this.commandFactory = commandFactory;
            this.labelFactory = labelFactory;

            this.InitializeSession();
        }

        private string AccountName { get; set; }

        private IMenu CurrentMenu { get => this.session.CurrentMenu; }

        private void InitializeSession()
        {
            this.session.PushView(new MainMenu(this.session,
                this.serviceProvider.GetService<ILabelFactory>(),
                this.serviceProvider.GetService<ICommandFactory>()));

            this.RenderCurrentView();
        }

        private void RenderCurrentView()
        {
            this.viewEngine.RenderMenu(this.session.CurrentMenu);
        }

        public void Back()
        {
            this.session.Back();
            RenderCurrentView();
        }

        public void Execute()
        {
            this.session.PushView(this.CurrentMenu.ExecuteCommand());
            this.RenderCurrentView();
        }

        public void MarkOption()
        {
            this.viewEngine.Mark(this.CurrentMenu.CurrentOption);
        }

        public void NextOption()
        {
            this.CurrentMenu.NextOption();
        }

        public void PreviousOption()
        {
            this.CurrentMenu.PreviousOption();
        }

        public void UnmarkOption()
        {
            this.viewEngine.Mark(this.CurrentMenu.CurrentOption, false);
        }
    }
}
