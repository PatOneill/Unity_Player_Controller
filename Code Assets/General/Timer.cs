using System;
using UnityEngine;

public class Timer : IUITimerDelayer {
    private float _MaxWaitTime;
    private float _ElapsedTime;
    private Action _TimerCompleteEvent;

    public Timer(float maxWaitTime, Action firstAction = null) {
        _MaxWaitTime = maxWaitTime;
        _ElapsedTime = 0.0f;
        _TimerCompleteEvent = firstAction;
    }

    public void ChangeCompletionEvent(Action newEvent) {
        /*
         *@Desc: Allows for the change of the current event that will happen once the timer goes off
         *@Parm: Action newEvent - This parameter hold the reference to an input event request 
        */
        if (_TimerCompleteEvent == null) { //Check to see if there is currently an active event
            _ElapsedTime = _MaxWaitTime; //Since there is no active event, this new event should be allowed to execute on the next call of the CountDown method
            _TimerCompleteEvent = newEvent;
        } else {
            _TimerCompleteEvent = newEvent;
        }
    }

    public void ClearCompletionEvent(Action oldEvent) {
        /*
         *@Desc: Forces all subscribers to unsubscribe from the current completion event
         *@Parm: Action oldEvent - This parameter hold the reference to an input event request that needs to be removed
        */
        _TimerCompleteEvent -= oldEvent;
    }

    public void CountDown() {
        /*
         *@Desc: If there is an active delegate, begin a count to add a slight delay between executions 
        */
        if (_TimerCompleteEvent != null) {
            _ElapsedTime += Time.deltaTime;
            if (_ElapsedTime >= _MaxWaitTime) {
                _TimerCompleteEvent();
                _ElapsedTime = 0.0f;
            }
        }
    }
}
