using System;

public interface IUITimerDelayer {
    void ChangeCompletionEvent(Action newEvent);
    void ClearCompletionEvent(Action newEvent);
}
