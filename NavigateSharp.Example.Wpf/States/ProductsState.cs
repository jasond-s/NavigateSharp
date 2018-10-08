using NavigateSharp.Example.Wpf.Presenters;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Example.Wpf.States
{
    public class ProductsState : NavigationState
    {
        private readonly Presenter _presenter;

        public ProductsState(IPresenterFactory presenterFactory)
                : base(presenterFactory) 
            => _presenter = PresenterFactory.Build<ProductsPresenter>();

        public override Presenter GetPresenter() 
            => _presenter;

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