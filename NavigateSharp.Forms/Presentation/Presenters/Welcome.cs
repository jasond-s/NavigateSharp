using System;

namespace NavigateSharp.Forms.Presentation.Presenters
{
    public partial class Welcome : View, IWelcomeView
    {
        public event WelcomeOkClickedEventHandler WelcomeOk;

        public string WelcomeText
        {
            get => this.welcomeText.Text;
            set => this.welcomeText.Text = value;
        }

        public Welcome()
        {
            InitializeComponent();
        }

        private void WelcomeOk_Click(Object sender, EventArgs e)
        {
            WelcomeOk?.Invoke(sender, new WelcomeOkClickedEvent());
        }
    }
}
