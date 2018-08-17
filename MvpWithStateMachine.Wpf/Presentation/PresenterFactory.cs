using MvpWithStateMachine.Presentation;
using MvpWithStateMachine.Wpf.Presentation.Presenters;

namespace MvpWithStateMachine.Wpf.Presentation
{
    public class PresenterFactory : IPresenterFactory
    {
        public Presenter Build<T>() where T : Presenter
        {
            var type = typeof(T);

            if (type == typeof(WelcomePresenter))
            {
                return new WelcomePresenter(new Presenters.Welcome());
            }

            return null;
        }
    }
}