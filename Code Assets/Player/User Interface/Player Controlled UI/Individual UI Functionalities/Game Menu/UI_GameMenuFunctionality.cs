using UnityEngine;

public class UI_GameMenuFunctionality : ICurrentUIElement {
    private ACustomUIElement _CurrentSelectedUIElement;
    private ResumeButton _ButtonResume;
    private SaveButton _ButtonSave;
    private LoadButton _ButtonLoad;
    private OptionButton _ButtonOption;
    private QuitButton _ButtonQuit;

    public UI_GameMenuFunctionality(GameObject playerGameMenu) {
        Transform uiContainer = playerGameMenu.transform.Find("GM_Background").transform;
        _ButtonResume = new ResumeButton(uiContainer, this);
        _ButtonSave = new SaveButton(uiContainer, this);
        _ButtonLoad = new LoadButton(uiContainer, this);
        _ButtonOption = new OptionButton(uiContainer, this);
        _ButtonQuit = new QuitButton(uiContainer, this);

        _ButtonResume.InitializeUINavigation(downUIElement: _ButtonSave);
        _ButtonSave.InitializeUINavigation(upUIElement: _ButtonResume, downUIElement: _ButtonLoad);
        _ButtonLoad.InitializeUINavigation(upUIElement: _ButtonSave, downUIElement: _ButtonOption);
        _ButtonOption.InitializeUINavigation(upUIElement: _ButtonLoad, downUIElement: _ButtonQuit);
        _ButtonQuit.InitializeUINavigation(upUIElement: _ButtonOption);

        _CurrentSelectedUIElement = _ButtonResume;
    }

    public ACustomUIElement CurrentSelectedUIElement { get => _CurrentSelectedUIElement; }

    public void SetCurrentSelectedCustomUIElement(ACustomUIElement newSelectedUIElement) {
        Debug.Log(_CurrentSelectedUIElement.GetUIName() + " is no longer selected.");
        _CurrentSelectedUIElement = newSelectedUIElement;
        Debug.Log(_CurrentSelectedUIElement.GetUIName() + " is selected.");
    }

    public void SetDefaultSelected() {
        _CurrentSelectedUIElement = _ButtonResume;
        Debug.Log(_CurrentSelectedUIElement.GetUIName() + " is selected.");
    }
}
