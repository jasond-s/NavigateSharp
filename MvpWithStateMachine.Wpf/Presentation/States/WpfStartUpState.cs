using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;
using MvpWithStateMachine.States;

namespace MvpWithStateMachine.Wpf.Presentation.States
{
    public class WpfStartUpState : StartUpState
    {
        public WpfStartUpState(IPresenterFactory presenterFactory) 
            : base(presenterFactory)
        {
        }

        public override NavigationState Next(NavigationEvent evt)
        {
            switch (evt)
            {
                case StartUpEvent startUpEvent:
                    return new WelcomeState(PresenterFactory);
                default:
                    return this;
            }
        }
    }
}