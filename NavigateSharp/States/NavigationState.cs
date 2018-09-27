using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;

namespace NavigateSharp.States
{
    public abstract class NavigationState
    {
        protected IPresenterFactory PresenterFactory;

        protected NavigationState(IPresenterFactory presenterFactory) 
            => PresenterFactory = presenterFactory;

        /// <summary>
        /// Return the presenter for the state, this is called on state changes.
        /// Therefore the presenter might have a lifetime separate to the state.
        /// </summary>
        /// <returns>A presenter</returns>
        public abstract Presenter GetPresenter();

        /// <summary>
        /// The state transition on receiving an event. This is also the place
        /// where any application state could be updated in response to the event.
        /// It is up to the developer whether they feel all state change should
        /// occur within a presenter or a navigation state, but consistency should
        /// always be favoured.
        /// </summary>
        /// <param name="evt"></param>
        /// <returns></returns>
        public abstract NavigationState Next(NavigationEvent evt);
    }
}