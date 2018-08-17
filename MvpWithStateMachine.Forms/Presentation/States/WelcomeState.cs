using MvpWithStateMachine.Forms.Presentation.Presenters;
using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;
using MvpWithStateMachine.States;

namespace MvpWithStateMachine.Forms.Presentation.States
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
                case WelcomeOkClickedEvent welcomeOkEvent:
                    return new ProductsState(PresenterFactory);
                case CloseApplicationEvent close:
                    return new FormsTearDownState();
                default:
                    return this;
            }
        }
    }
}