﻿using MvpWithStateMachine.Forms.Presentation.Presenters;
using MvpWithStateMachine.Presentation;

namespace MvpWithStateMachine.Forms.Presentation
{
    public class PresenterFactory : IPresenterFactory
    {
        public PresenterFactory(/* this should take some kind of container */)
        {
            
        }

        public Presenter Build<T>() where T : Presenter
        {
            var type = typeof(T);
            
            if (type == typeof(WelcomePresenter))
            {
                return new WelcomePresenter(new Welcome());
            }

            if (type == typeof(ProductsPresenter))
            {
                return new ProductsPresenter(new Products());
            }

            return null;
        }
    }
}