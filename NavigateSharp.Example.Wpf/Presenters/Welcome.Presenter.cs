using NavigateSharp.Example.Wpf.States;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;

namespace NavigateSharp.Example.Wpf.Presenters
{
    public class WelcomePresenter : Presenter<IWelcomeView>
    {
        private readonly IApplicationData _applicationData;

        public WelcomePresenter(IWelcomeView welcomeView, IApplicationData applicationData)
            : base(welcomeView)
        {
            _applicationData = applicationData;
        }

        protected override void OnDisplay(NavigationEvent evt)
        {
            // Get all the state from the service, rather than directly from the event.

            View.WelcomeText = _applicationData.GetIntroductionText();

            // Register the view handlers to presenter methods. 

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
