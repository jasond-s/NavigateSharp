using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Example.Forms.States
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
                case StartUpEvent startUpEvent:
                    return new WelcomeState(PresenterFactory);
                default:
                    return this;
            }
        }
    }
}