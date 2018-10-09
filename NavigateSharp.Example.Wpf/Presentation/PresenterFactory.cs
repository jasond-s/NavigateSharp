using NavigateSharp.Example.Wpf.Presenters;
using NavigateSharp.Presentation;

namespace NavigateSharp.Example.Wpf.Presentation
{
    public class PresenterFactory : IPresenterFactory
    {
        private readonly PoorMansDi _diContainer;

        public PresenterFactory(PoorMansDi diContainer) 
            => _diContainer = diContainer;

        public Presenter Build<T>() where T : Presenter
        {
            var type = typeof(T);

            if (type == typeof(WelcomePresenter))
            {
                return new WelcomePresenter(new Welcome(), _diContainer.ApplicationData);
            }

            if (type == typeof(ProductsPresenter))
            {
                return new ProductsPresenter(new Products());
            }

            return null;
        }
    }
}