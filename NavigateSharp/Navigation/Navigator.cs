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
        private NavigationState _current;
		
        public void NavigateTo(NavigationEvent evt)
        {
            if (_current == null)
            {
                throw new ArgumentException("State not initialised, must initialise navigator with starting state", nameof(NavigationState));
            }

            NavigateTo(_current.Next(evt), evt);
        }
		
        private void NavigateTo(NavigationState nextState, NavigationEvent evt)
        {
            if (_current == nextState)
            {
                return;
            }

            var currentPresenter = _current?.GetPresenter();
            var nextPresenter = nextState?.GetPresenter();
            
            if (currentPresenter != null)
            {
                currentPresenter.Dismiss();
                currentPresenter.Navigator = null;
                _current = null;
            }

            if (nextPresenter != null)
            {
                _current = nextState;
                nextPresenter.Navigator = this;
                nextPresenter.Display(evt);
            }
        }

        public void InitialiseWith(StartUpState startUp)
        {
            _current = startUp;
        }
    }
}