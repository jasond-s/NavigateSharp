using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Example.Wpf.States
{
    public class WpfStartUpState : StartUpState
    {
        private readonly IApplicationData _appState;

        public WpfStartUpState(IPresenterFactory presenterFactory, IApplicationData appState) 
            : base(presenterFactory)
        {
            _appState = appState;
        }

        public override NavigationState Next(NavigationEvent evt)
        {
            switch (evt)
            {
                case StartUpEvent startUpEvent:

                    _appState.SetIntroductionText(startUpEvent.Introduction);

                    return new WelcomeState(PresenterFactory);
                default:
                    return this;
            }
        }
    }
}