using System.Windows.Forms;
using NavigateSharp.States;

namespace NavigateSharp.Example.Forms.Presentation.States
{
    public class FormsTearDownState : TearDownState
    {
        public override void Close()
        {
            Application.Exit();
        }
    }
}