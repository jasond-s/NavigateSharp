using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;
using MvpWithStateMachine.States;
using MvpWithStateMachine.Wpf.Presentation.Presenters;

namespace MvpWithStateMachine.Wpf.Presentation.States
{
    public class WelcomeState : NavigationState
    {
        public WelcomeState(IPresenterFactory presenterFactory) 
            : base(presenterFactory)
        {
        }

        public override Presenter GetPresentor()
        {
            return PresenterFactory.Build<WelcomePresenter>();
        }

        public override NavigationState Next(NavigationEvent evt)
        {
            switch (evt)
            {
                case CloseApplicationEvent closeApplicationEvent:
                    return new WpfTearDownState();
                default:
                    return this;
            }
        }
    }
}
