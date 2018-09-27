using System.Windows;
using NavigateSharp.Example.Wpf.Presentation;
using NavigateSharp.Example.Wpf.States;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Wpf;

namespace NavigateSharp.Example.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Current.MainWindow = new NavigationContext(
                new WpfStartUpState(new PresenterFactory()),
                new StartUpEvent("Welcome"));
        }
    }
}
