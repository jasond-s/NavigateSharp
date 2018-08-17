using MvpWithStateMachine.Forms.Presentation.Presenters;
using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;
using MvpWithStateMachine.States;

namespace MvpWithStateMachine.Forms.Presentation.States
{
    public class FormsStartupState : StartUpState
    {
        public FormsStartupState(IPresenterFactory presenterFactory) 
            : base(presenterFactory)
        {
        }

        public override NavigationState Next(NavigationEvent evt)
        {
            switch (evt)
            {
                case WelcomeOkClickedEvent welcomeOk:
                    return new WelcomeState(PresenterFactory);
                default:
                    return this;
            }
        }
    }
}