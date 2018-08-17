using NavigateSharp.Forms.Presentation.Presenters;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Forms.Presentation.States
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