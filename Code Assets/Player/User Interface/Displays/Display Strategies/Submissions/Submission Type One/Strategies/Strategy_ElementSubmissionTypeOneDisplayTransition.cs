using System.Threading.Tasks;
using System;
using UnityEngine;

public class Strategy_ElementSubmissionTypeOneDisplayTransition : IUIElementSubmissionTypeOne {
    private Animator _ButtonAnimator;
    private Action _SubmissionEvent;
    public Strategy_ElementSubmissionTypeOneDisplayTransition(Animator buttonAnimator, Action submissionEvent) {
        _ButtonAnimator = buttonAnimator;
        _SubmissionEvent = submissionEvent;
    }

    public async Task SubmissionTypeOneAsync() {
        /*
         *@Desc: Upon receiving a submission request, play the animation for submission and execute this button's functionality
        */
        _ButtonAnimator.SetBool("Pressed", true);

        int waitTime = (int)(_ButtonAnimator.GetCurrentAnimatorStateInfo(0).length * 1000f);
        await Task.Delay(waitTime);
        _SubmissionEvent();
        _SubmissionEvent = null;
    }
}
