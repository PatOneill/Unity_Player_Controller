using UnityEngine;

public class SaveButton : ACustomUIElement {
    private const string _ButtonName = "GM_SaveButton";

    public SaveButton(Transform uiContainer, ICurrentUIElement currentUIElementSeter) {
        _AnimatorUI = uiContainer.transform.Find(_ButtonName).GetComponent<Animator>();
        _CurrentSelectedUIElement = currentUIElementSeter;
    }

    public override string GetUIName() {
        return _ButtonName;
    }

    public override void PressEvent() {
        throw new System.NotImplementedException();
    }
}
