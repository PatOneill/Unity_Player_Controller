using UnityEngine;

public abstract class AUIController {
    protected GameObject _UnityUIDisplay;
    protected IUINavigationCommands _UINavigationCommands;

    public virtual void TransitionToHudUI() {
        return;
    }

    public virtual void TransitionToGameMenuUI() {
        return;
    }

    public virtual IUINavigationCommands GetUINavigation() {
        return _UINavigationCommands;
    }

    public void UIDisplayOn() {
        /**
          * @desc Enables a unity UI gameobject
        */
        _UnityUIDisplay.SetActive(true);
    }

    public void UIDisplayOff() {
        /**
          * @desc Disables a unity UI gameobject
        */
        _UnityUIDisplay.SetActive(false);
    }
}
