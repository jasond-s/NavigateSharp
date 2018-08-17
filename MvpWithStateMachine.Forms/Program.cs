using System;
using System.Windows.Forms;
using MvpWithStateMachine.Forms.Presentation;
using MvpWithStateMachine.Forms.Presentation.States;
using MvpWithStateMachine.Navigation.Events;

namespace MvpWithStateMachine.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NavigationContext(
                new FormsStartupState(new PresenterFactory()),
                new StartUpEvent("Hello")));
        }
    }
}
