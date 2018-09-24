using NavigateSharp.Example.Wpf.Presentation.Presenters;
using NavigateSharp.Presentation;

namespace NavigateSharp.Example.Wpf.Presentation
{
    public class PresenterFactory : IPresenterFactory
    {
        public Presenter Build<T>() where T : Presenter
        {
            var type = typeof(T);

            if (type == typeof(WelcomePresenter))
            {
                return new WelcomePresenter(new Welcome());
            }

            return null;
        }
    }
}