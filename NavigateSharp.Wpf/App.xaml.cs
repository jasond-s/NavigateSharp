using System.Windows;
using NavigateSharp.Navigation;
using NavigateSharp.Navigation.Events;
using NavigateSharp.States;
using NavigateSharp.Wpf.Presentation;
using NavigateSharp.Wpf.Presentation.States;

namespace NavigateSharp.Wpf
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

    public class NavigationContext : Window
    {
        private readonly Navigator _navigator;

        public NavigationContext(StartUpState startUpState, NavigationEvent startUpEvent)
        {
            _navigator = new Navigator();
            _navigator.InitialiseWith(startUpState);
            _navigator.NavigateTo(startUpEvent);
        }
    }
}
