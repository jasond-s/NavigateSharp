using NavigateSharp.Example.Forms.Presenters;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Example.Forms.States
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
                case WelcomeOkEvent welcomeOkEvent:
                    return new ProductsState(PresenterFactory);
                case CloseViewEvent closeViewEvent:
                case CloseApplicationEvent close:
                    return new FormsTearDownState();
                default:
                    return this;
            }
        }
    }
}