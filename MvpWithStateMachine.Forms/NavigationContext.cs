using System.Windows.Forms;
using MvpWithStateMachine.Navigation;
using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.States;

namespace MvpWithStateMachine.Forms
{
    public class NavigationContext : ApplicationContext
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