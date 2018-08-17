using System.Windows;
using MvpWithStateMachine.States;

namespace MvpWithStateMachine.Wpf.Presentation.States
{
    public class WpfTearDownState : TearDownState
    {
        public override void Close()
        {
            Application.Current.Shutdown();
        }
    }
}
