using System;

namespace NavigateSharp.Example.Forms.Presentation.Presenters
{
    public partial class Welcome : View, IWelcomeView
    {
        public event WelcomeOkClickedEventHandler WelcomeOk;

        public string WelcomeText
        {
            get => welcomeText.Text;
            set => welcomeText.Text = value;
        }

        public Welcome() 
            => InitializeComponent();

        private void WelcomeOk_Click(object sender, EventArgs e) 
            => WelcomeOk?.Invoke(sender, new WelcomeOkClickedEvent());
    }
}
