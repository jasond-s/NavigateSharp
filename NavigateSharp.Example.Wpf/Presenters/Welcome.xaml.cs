using System;
using NavigateSharp.Wpf;

namespace NavigateSharp.Example.Wpf.Presenters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Welcome : View, IWelcomeView
    {
        public Welcome()
        {
            InitializeComponent();
        }

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
