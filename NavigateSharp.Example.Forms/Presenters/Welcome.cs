using System;
using NavigateSharp.Forms;

namespace NavigateSharp.Example.Forms.Presenters
{
    public partial class Welcome : View, IWelcomeView
    {
        public Welcome()
            => InitializeComponent();

        public string WelcomeText
        {
            get => welcomeText.Text;
            set => welcomeText.Text = value;
        }

        public event WelcomeOkClickedEventHandler WelcomeOk;

        private void WelcomeOk_Click(object sender, EventArgs e)
            => WelcomeOk?.Invoke(sender, new WelcomeOkEvent());
    }
}
