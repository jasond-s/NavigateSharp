using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;

namespace MvpWithStateMachine.States
{
    public abstract class NavigationState
    {
        protected IPresenterFactory PresenterFactory;

        protected NavigationState(IPresenterFactory presenterFactory) 
            => PresenterFactory = presenterFactory;

        public abstract Presenter GetPresentor();

        public abstract NavigationState Next(NavigationEvent evt);
    }
}