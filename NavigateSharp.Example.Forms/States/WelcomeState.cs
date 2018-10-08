using NavigateSharp.Example.Forms.Presenters;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Example.Forms.States
{
    public class WelcomeState : NavigationState
    {
        private readonly Presenter _presenter;

        public WelcomeState(IPresenterFactory presenterFactory)
                : base(presenterFactory) 
            => _presenter = PresenterFactory.Build<WelcomePresenter>();

        public override Presenter GetPresenter() 
            => _presenter;

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