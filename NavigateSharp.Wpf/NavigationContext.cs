using System;
using System.Windows;
using NavigateSharp.Navigation;
using NavigateSharp.Navigation.Events;
using NavigateSharp.States;

namespace NavigateSharp.Wpf
{
    public class NavigationContext : Window
    {
        private readonly Navigator _navigator;

        public NavigationContext(StartUpState startUpState, NavigationEvent startUpEvent)
        {
            _navigator = new Navigator();
            _navigator.InitialiseWith(startUpState);
            _navigator.NavigateTo(startUpEvent);
        }

        protected override void OnClosed(EventArgs e)
        {
            _navigator.NavigateTo(new CloseApplicationEvent());
            base.OnClosed(e);
        }
    }
}