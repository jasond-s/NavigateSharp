using NavigateSharp.Forms.Presentation.Presenters;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;
using NavigateSharp.States;

namespace NavigateSharp.Forms.Presentation.States
{
    public class ProductsState : NavigationState
    {
        public ProductsState(IPresenterFactory presenterFactory) 
            : base(presenterFactory)
        {
        }

        public override Presenter GetPresentor()
        {
            return PresenterFactory.Build<ProductsPresenter>();
        }

        public override NavigationState Next(NavigationEvent evt)
        {
            switch (evt)
            {
                default:
                    return this;
            }
        }
    }
}