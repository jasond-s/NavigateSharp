﻿using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;

namespace MvpWithStateMachine.Forms.Presentation.Presenters
{
    public class ProductsPresenter : Presenter
    {
        private readonly IProductsView _productsView;

        public ProductsPresenter(IProductsView productsView) 
            : base(productsView)
        {
            _productsView = productsView;
        }

        protected override void OnDisplay(NavigationEvent evt)
        {
            _productsView.Show();
        }

        protected override void OnDismiss()
        {
            _productsView.Close();
        }
    }

    public interface IProductsView : IView
    {

    }
}
