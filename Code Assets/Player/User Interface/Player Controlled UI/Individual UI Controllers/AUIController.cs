using UnityEngine;

public abstract class AUIController : IUITransitionCommands, IUIControllerNavigationCommands {
    protected GameObject _UnityUIDisplay;

    public virtual void TransitionToHudUI() {
        return;
    }

    public virtual void TransitionToGameMenuUI() {
        return;
    }

    public virtual void UIDisplayOn() {
        /**
          * @desc Enables a unity UI gameobject
        */
        _UnityUIDisplay.SetActive(true);
    }

    public virtual void UIDisplayOff() {
        /**
          * @desc Disables a unity UI gameobject
        */
        _UnityUIDisplay.SetActive(false);
    }

    public virtual void NavigateVertically(int direction) {
        return;
    }

    public virtual void NavigateHorizontally(int direction) {
        return;
    }

    public virtual void NavigateSelectablePressed() {
        return;
    }
}
