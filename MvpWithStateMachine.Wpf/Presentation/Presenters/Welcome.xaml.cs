namespace MvpWithStateMachine.Wpf.Presentation.Presenters
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
    }
}
