using NavigateSharp.Presentation;

namespace NavigateSharp.States
{
    public abstract class StartUpState : NavigationState
    {
        protected StartUpState(IPresenterFactory presenterFactory) 
            : base(presenterFactory)
        {
        }

        public override Presenter GetPresenter()
        {
            return new StartUpPresenter();
        }

        public class StartUpView : IView
        {
            public void Show()
                => throw new System.NotImplementedException();

            public bool? ShowAsDialog()
                => throw new System.NotImplementedException();

            public void Hide()
                => throw new System.NotImplementedException();

            public void Close()
                => throw new System.NotImplementedException();

            public event CloseClickedEventHandler CloseRequest;
        }

        public class StartUpPresenter : Presenter
        {
            public StartUpPresenter() 
                : base(new StartUpView())
            {
            }
        }
    }
}