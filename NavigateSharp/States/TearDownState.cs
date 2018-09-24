using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;

namespace NavigateSharp.States
{
    public abstract class TearDownState : NavigationState
    {
        public abstract void Close();

        protected TearDownState() 
            : base(null)
        {

        }

        public override Presenter GetPresenter()
        {
            return new TearDownPresenter(this);
        }

        public override NavigationState Next(NavigationEvent evt)
        {
            // End state.
            return this;
        }

        public class TearDownPresenter : Presenter
        {
            private readonly TearDownState _state;

            public TearDownPresenter(TearDownState state) : base(new TearDownView())
            {
                _state = state;
            }

            protected override void OnDisplay(NavigationEvent evt)
            {
                _state?.Close();
            }
        }

        public class TearDownView : IView
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
    }
}