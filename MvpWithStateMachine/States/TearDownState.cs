using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;

namespace MvpWithStateMachine.States
{
    public abstract class TearDownState : NavigationState
    {
        public abstract void Close();

        protected TearDownState() 
            : base(null)
        {

        }

        public override Presenter GetPresentor()
        {
            return new TearDownPresentor(this);
        }

        public override NavigationState Next(NavigationEvent evt)
        {
            // End state.
            return this;
        }

        public class TearDownPresentor : Presenter
        {
            private readonly TearDownState _state;

            public TearDownPresentor(TearDownState state) : base(new TearDownView())
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