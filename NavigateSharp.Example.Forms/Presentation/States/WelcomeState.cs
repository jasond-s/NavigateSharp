using NavigateSharp.Example.Forms.Presentation.Presenters;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Example.Forms.Presentation.States
{
    public class WelcomeState : NavigationState
    {
        public WelcomeState(IPresenterFactory presenterFactory) 
            : base(presenterFactory)
        {
        }

        public override Presenter GetPresenter()
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