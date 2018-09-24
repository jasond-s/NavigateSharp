using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Example.Wpf.Presentation.States
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