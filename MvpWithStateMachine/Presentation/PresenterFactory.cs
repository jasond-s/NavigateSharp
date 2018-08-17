namespace MvpWithStateMachine.Presentation
{
    public interface IPresenterFactory
    {
        Presenter Build<T>() where T : Presenter;
    }
}