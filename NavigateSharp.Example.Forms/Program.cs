using System;
using System.Windows.Forms;
using NavigateSharp.Example.Forms.Presentation;
using NavigateSharp.Example.Forms.States;
using NavigateSharp.Forms;
using NavigateSharp.Navigation.Events;

namespace NavigateSharp.Example.Forms
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
                new StartUpEvent("Welcome to NavigateSharp")));
        }
    }
}
