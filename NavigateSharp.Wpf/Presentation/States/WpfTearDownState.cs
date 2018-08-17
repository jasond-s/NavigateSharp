using System.Windows;
using NavigateSharp.States;

namespace NavigateSharp.Wpf.Presentation.States
{
    public class WpfTearDownState : TearDownState
    {
        public override void Close()
        {
            Application.Current.Shutdown();
        }
    }
}
