using System.ComponentModel;
using System.Windows.Forms;
using MvpWithStateMachine.Navigation.Events;
using MvpWithStateMachine.Presentation;

namespace MvpWithStateMachine.Forms.Presentation
{
    public abstract class View : Form, IView
    {
        public bool? ShowAsDialog()
        {
            var result = ShowDialog();
            return 
                result == DialogResult.OK || 
                result == DialogResult.Yes;
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