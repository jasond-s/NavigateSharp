using System.Windows;
using NavigateSharp.States;

namespace NavigateSharp.Example.Wpf.States
{
    public class WpfTearDownState : TearDownState
    {
        public override void Close()
        {
            Application.Current.Shutdown();
        }
    }
}
