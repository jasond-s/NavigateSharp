using System.Windows;
using NavigateSharp.Example.Wpf.Presentation;
using NavigateSharp.Example.Wpf.States;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Wpf;

namespace NavigateSharp.Example.Wpf
{
    public class PoorMansDi
    {
        public IApplicationData ApplicationData = new ApplicationData();
    }

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var diContainer = new PoorMansDi();

            Current.MainWindow = new NavigationContext(
                new WpfStartUpState(new PresenterFactory(diContainer), diContainer.ApplicationData),
                new StartUpEvent("Welcome to NavigateSharp"));
        }
    }
}
