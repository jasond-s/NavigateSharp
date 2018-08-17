using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;
using NavigateSharp.Wpf.Presentation.Presenters;

namespace NavigateSharp.Wpf.Presentation.States
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
