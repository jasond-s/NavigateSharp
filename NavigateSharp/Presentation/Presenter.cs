using NavigateSharp.Navigation;
using NavigateSharp.Navigation.Events;

namespace NavigateSharp.Presentation
{
    public abstract class Presenter
    {
        public INavigator Navigator { get; set; }
        public IView View { get; }

        protected Presenter(IView view)
        {
            View = view;
        }

        public void Display(NavigationEvent evt)
        {
            OnDisplay(evt);
        }

        public void Dismiss()
        {
            OnDismiss();
        }

        protected virtual void OnDisplay(NavigationEvent evt)
        {
        }

        protected virtual void OnDismiss()
        {
        }
    }
}