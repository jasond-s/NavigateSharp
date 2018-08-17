using System.ComponentModel;
using System.Windows;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;

namespace NavigateSharp.Wpf.Presentation
{
    public abstract class View : Window, IView
    {
        public bool? ShowAsDialog()
        {
            return ShowDialog();
        }

        public event CloseClickedEventHandler CloseRequest;

        protected View()
        {
            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            CloseRequest?.Invoke(sender, new CloseApplicationEvent());
            cancelEventArgs.Cancel = true;
        }
    }
}
