using NavigateSharp.Example.Forms.Presenters;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Example.Forms.States
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
                case ProductsBackEvent productsBack:
                    return new WelcomeState(PresenterFactory);
                default:
                    return this;
            }
        }
    }
}