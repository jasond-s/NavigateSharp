using System.ComponentModel;
using System.Windows.Forms;
using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;

namespace NavigateSharp.Forms
{
    public class View : Form, IView
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
            CloseRequest?.Invoke(sender, new CloseViewEvent());
        }
    }
}