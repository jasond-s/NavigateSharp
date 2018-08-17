using NavigateSharp.Presentation;
using NavigateSharp.Wpf.Presentation.Presenters;

namespace NavigateSharp.Wpf.Presentation
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