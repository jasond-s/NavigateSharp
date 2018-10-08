using NavigateSharp.Navigation;
using NavigateSharp.Navigation.Events;

namespace NavigateSharp.Presentation
{
    public abstract class Presenter
    {
        public INavigator Navigator { get; internal set; }

        public void Display(NavigationEvent evt) 
            => OnDisplay(evt);

        public void Dismiss() 
            => OnDismiss();

        protected virtual void OnDisplay(NavigationEvent evt)
        {
        }

        protected virtual void OnDismiss()
        {
        }
    }

    public abstract class Presenter<T> : Presenter where T : IView
    {
        public T View { get; }

        protected Presenter(T view) 
            => View = view;
    }
}