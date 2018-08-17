using System.Windows.Forms;
using MvpWithStateMachine.States;

namespace MvpWithStateMachine.Forms.Presentation.States
{
    public class FormsTearDownState : TearDownState
    {
        public override void Close()
        {
            Application.Exit();
        }
    }
}