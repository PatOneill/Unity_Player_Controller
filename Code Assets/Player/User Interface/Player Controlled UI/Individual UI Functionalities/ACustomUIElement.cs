using UnityEngine;

public abstract class ACustomUIElement {
    protected Animator _AnimatorUI;
    protected ICurrentUIElement _CurrentSelectedUIElement;
    private ACustomUIElement _UpUIElement;
    private ACustomUIElement _DownUIElement;
    private ACustomUIElement _RightUIElement;
    private ACustomUIElement _LeftUIElement;

    public void InitializeUINavigation(ACustomUIElement upUIElement = null, ACustomUIElement downUIElement = null, ACustomUIElement rightUIElement = null, ACustomUIElement leftUIElement = null) {
        _UpUIElement = upUIElement;
        _DownUIElement = downUIElement;
        _RightUIElement = rightUIElement;
        _LeftUIElement = leftUIElement;
    }

    public abstract string GetUIName();

    public void ShiftUp() {
        /**
          * @desc Takes the currently selected UI element and check to see if a transition path exist to the above. If so, make element to the above the new current selected UI element
        */
        if (_UpUIElement == null) { return; }
        _CurrentSelectedUIElement.SetCurrentSelectedCustomUIElement(_UpUIElement);
    }

    public void ShiftDown() {
        /**
          * @desc Takes the currently selected UI element and check to see if a transition path exist to the below. If so, make element to the below the new current selected UI element
        */
        if (_DownUIElement == null) { return; }
        _CurrentSelectedUIElement.SetCurrentSelectedCustomUIElement(_DownUIElement);
    }

    public void ShiftRight() {
        /**
          * @desc Takes the currently selected UI element and check to see if a transition path exist to the right. If so, make element to the right the new current selected UI element
        */
        if (_RightUIElement == null) { return; }
        _CurrentSelectedUIElement.SetCurrentSelectedCustomUIElement(_RightUIElement);
    }

    public void ShiftLeft() {
        /**
          * @desc Takes the currently selected UI element and check to see if a transition path exist to the left. If so, make element to the left the new current selected UI element
        */
        if (_LeftUIElement == null) { return; }
        _CurrentSelectedUIElement.SetCurrentSelectedCustomUIElement(_LeftUIElement);
    }

    public abstract void PressEvent();
}
