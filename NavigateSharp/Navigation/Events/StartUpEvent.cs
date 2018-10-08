namespace NavigateSharp.Navigation.Events
{
    public class StartUpEvent : NavigationEvent
    {
        public StartUpEvent(string introduction) 
            => Introduction = introduction;

        public string Introduction { get; }
    }
}