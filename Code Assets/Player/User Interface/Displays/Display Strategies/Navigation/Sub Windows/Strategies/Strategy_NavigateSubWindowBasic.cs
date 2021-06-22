using UnityEngine;
using System;
public class Strategy_NavigateSubWindowBasic : IUISubWindowNavigation {
    private Animator _SubWindowAnimator;
    private Action _TransitionEvent;
    private IReceiverHandlerSubWindowNavigation _UISubWindowNavigationReceiver;
    private IUISubWindowNavigation _LeftSubWindow;
    private IUISubWindowNavigation _RightSubWindow;

    public Strategy_NavigateSubWindowBasic(Animator subWindowAnimator, IGetReceiverFunctionality inputReceivers, Action transitionEvent) {
        _SubWindowAnimator = subWindowAnimator;
        _UISubWindowNavigationReceiver = inputReceivers.GetSubWindowNavigation;
        _TransitionEvent = transitionEvent;
        _LeftSubWindow = null;
        _RightSubWindow = null;
    }

    public void SetupElementNavigation(IUISubWindowNavigation leftElement = null, IUISubWindowNavigation rightElement = null) {
        _LeftSubWindow = leftElement;
        _RightSubWindow = rightElement;
    }

    public void NavigateLeft() {
        /*
         *@Desc: If there is a sub window to the left assigned to the current selected sub window, allow the sub window to the left to be selected, while this sub window becomes unselected
        */
        if (_LeftSubWindow == null) { return; }
        this.SubWindowUnselected();

        _LeftSubWindow.SubWindowSelected();
    }

    public void NavigateRight() {
        /*
         *@Desc: If there is a sub window to the right assigned to the current selected sub window, allow the sub window to the right to be selected, while this sub window becomes unselected
        */
        if (_RightSubWindow == null) { return; }
        this.SubWindowUnselected();

        _RightSubWindow.SubWindowSelected();
    }

    public void SubWindowSelected() {
        /*
         *@Desc: When a sub window becomes selected, play the animation of selection
        */
        _SubWindowAnimator.SetBool("Selected", true);
        _UISubWindowNavigationReceiver.SetUISubWindowNavigationStrategy = this;
        _TransitionEvent();
    }

    public void SubWindowUnselected() {
        /*
         *@Desc: When a sub window becomes unselected, play the animation of unselection
        */
        _SubWindowAnimator.SetBool("Selected", false);
    }
}
