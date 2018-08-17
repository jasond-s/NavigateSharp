using MvpWithStateMachine.Forms.Presentation.Presenters;
using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;
using MvpWithStateMachine.States;

namespace MvpWithStateMachine.Forms.Presentation.States
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