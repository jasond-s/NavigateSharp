using System;
using NavigateSharp.Navigation.Events;
using NavigateSharp.States;

namespace NavigateSharp.Navigation
{
    public interface INavigator
    {
        void NavigateTo(NavigationEvent evt);
    }

    public class Navigator : INavigator
    {
        private NavigationState _currentState;

        public void NavigateTo(NavigationEvent evt)
        {
            if (_currentState == null)
            {
                throw new ArgumentException("State not initialised, must initialise navigator with starting state", nameof(NavigationState));
            }

            NavigateTo(_currentState.Next(evt), evt);
        }

        private void NavigateTo(NavigationState nextState, NavigationEvent evt)
        {
            if (_currentState == nextState)
            {
                return;
            }

            var currentPresenter = _currentState?.GetPresenter();
            var nextPresenter = nextState?.GetPresenter();

            _currentState = null;

            if (nextPresenter != null)
            {
                _currentState = nextState;
                nextPresenter.Navigator = this;
                nextPresenter.Display(evt);
            }

            if (currentPresenter != null)
            {
                currentPresenter.Dismiss();
                currentPresenter.Navigator = null;
            }
        }

        internal void InitialiseWith(StartUpState startUp) 
            => _currentState = startUp;
    }
}