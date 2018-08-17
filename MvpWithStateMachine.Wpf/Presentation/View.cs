using System.ComponentModel;
using System.Windows;
using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;

namespace MvpWithStateMachine.Wpf.Presentation
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
