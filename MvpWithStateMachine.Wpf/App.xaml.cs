using System.Windows;
using MvpWithStateMachine.Navigation;
using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.States;
using MvpWithStateMachine.Wpf.Presentation;
using MvpWithStateMachine.Wpf.Presentation.States;

namespace MvpWithStateMachine.Wpf
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
