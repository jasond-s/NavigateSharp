using NavigateSharp.Navigation.Events;

namespace NavigateSharp.Presentation
{
    public interface IView
    {
        void Show();
        bool? ShowAsDialog();

        void Hide();

        void Close();

        event CloseClickedEventHandler CloseRequest;
    }

    public delegate void CloseClickedEventHandler(object sender, CloseApplicationEvent args);
}