﻿using System.Windows.Forms;
using NavigateSharp.Navigation;
using NavigateSharp.Navigation.Events;
using NavigateSharp.States;

namespace NavigateSharp.Forms
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