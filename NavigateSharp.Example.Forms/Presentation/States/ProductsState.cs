using NavigateSharp.Example.Forms.Presentation.Presenters;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Example.Forms.Presentation.States
{
    public class ProductsState : NavigationState
    {
        public ProductsState(IPresenterFactory presenterFactory) 
            : base(presenterFactory)
        {
        }

        public override Presenter GetPresenter()
        {
            return PresenterFactory.Build<ProductsPresenter>();
        }

        public override NavigationState Next(NavigationEvent evt)
        {
            switch (evt)
            {
                case CloseViewEvent close:
                    return new WelcomeState(PresenterFactory);
                default:
                    return this;
            }
        }
    }
}