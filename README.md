# NavigateSharp

### Or M(odel)V(iew)P(resenter) with State Machine

## Considerations

1. All views must be represented in one or more states.
2. All states must define state transitions.
3. All state changes must be triggered from an event.
4. All views must be passive.
5. All views must have a corresponding presenter.
6. All data must be orchestrated by the presenter.
7. All the information necessary for state transitions must be passed in the event.
8. No view may directly message another view.
9. No presenter may directly message another presenter.
10. All data that is passed between views must represent a state transition.
11. All static information must be held in a service.
12. All data must be retrieved through a service.
13. No data state may reside soley within a passive view, it must be passed through the presenter to services.
14. ??
15. Profit.
