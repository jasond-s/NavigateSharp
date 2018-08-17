using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;

namespace MvpWithStateMachine.Wpf.Presentation.Presenters
{
    public class WelcomePresenter : Presenter
    {
        private readonly IWelcomeView _welcomeView;

        public WelcomePresenter(IWelcomeView view) 
            : base(view)
        {
            _welcomeView = view;
        }

        protected override void OnDisplay(NavigationEvent evt)
        {
            if (evt is StartUpEvent startUpEvent)
            {
                _welcomeView.WelcomeText = startUpEvent.Introduction;
            }

            _welcomeView.Show();
        }
    }

    public interface IWelcomeView : IView
    {
        string WelcomeText { get; set; }
    }
}
