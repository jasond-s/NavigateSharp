using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;

namespace NavigateSharp.Example.Wpf.Presenters
{
    public class WelcomePresenter : Presenter<IWelcomeView>
    {
        public WelcomePresenter(IWelcomeView welcomeView)
            : base(welcomeView)
        {

        }

        protected override void OnDisplay(NavigationEvent evt)
        {
            if (evt is StartUpEvent startUpEvent)
            {
                View.WelcomeText = startUpEvent.Introduction;
            }

            View.WelcomeOk += WelcomeViewOnWelcomeOk;
            View.CloseRequest += WelcomeViewCloseClicked;
            View.Show();
        }

        protected override void OnDismiss()
        {
            View.WelcomeOk -= WelcomeViewOnWelcomeOk;
            View.CloseRequest -= WelcomeViewCloseClicked;
            View.Close();
        }

        private void WelcomeViewOnWelcomeOk(object sender, WelcomeOkEvent args)
            => Navigator.NavigateTo(args);

        private void WelcomeViewCloseClicked(object sender, CloseViewEvent args)
            => Navigator.NavigateTo(args);
    }

    public interface IWelcomeView : IView
    {
        event WelcomeOkClickedEventHandler WelcomeOk;

        string WelcomeText { get; set; }
    }

    public class WelcomeOkEvent : NavigationEvent
    {

    }

    public delegate void WelcomeOkClickedEventHandler(object sender, WelcomeOkEvent args);
}
