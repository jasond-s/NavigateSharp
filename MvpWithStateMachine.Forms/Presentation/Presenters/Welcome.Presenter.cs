using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;

namespace MvpWithStateMachine.Forms.Presentation.Presenters
{
    public class WelcomeOkClickedEvent : NavigationEvent { }

    public class WelcomePresenter : Presenter
    {
        private readonly IWelcomeView _welcomeView;

        public WelcomePresenter(IWelcomeView welcomeView) 
            : base(welcomeView)
        {
            _welcomeView = welcomeView;
        }

        protected override void OnDisplay(NavigationEvent evt)
        {
            if (evt is StartUpEvent startUpEvent)
            {
                _welcomeView.WelcomeText = startUpEvent.Introduction;
            }

            _welcomeView.WelcomeOk += WelcomeViewOnWelcomeOk;
            _welcomeView.CloseRequest += WelcomeViewCloseClicked;
			_welcomeView.Show();
        }

        protected override void OnDismiss()
        {
			_welcomeView.WelcomeOk -= WelcomeViewOnWelcomeOk;
            _welcomeView.CloseRequest -= WelcomeViewCloseClicked;
			_welcomeView.Close();
        }

        private void WelcomeViewOnWelcomeOk(object sender, WelcomeOkClickedEvent args)
            => Navigator.NavigateTo(args);

        private void WelcomeViewCloseClicked(object sender, CloseApplicationEvent args)
            => Navigator.NavigateTo(args);
    }

    public interface IWelcomeView : IView
    {
        event WelcomeOkClickedEventHandler WelcomeOk;

        string WelcomeText { get; set; }
    }

    public delegate void WelcomeOkClickedEventHandler(object sender, WelcomeOkClickedEvent args);
}
