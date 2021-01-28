using UnityEngine;

public class Input_GameMenuEvent : IButtonUIController {
    private readonly IStateProxyOnOff _ProxyOpenGameMenu;
    private readonly InputDeviceLayout _InputDeviceLayout;

    public Input_GameMenuEvent(IStateProxyOnOff openMenu, InputDeviceLayout inputDeviceLayout) {
        _ProxyOpenGameMenu = openMenu;
        _InputDeviceLayout = inputDeviceLayout;
    }

    public void ButtonStart() {
        _InputDeviceLayout.Player.Disable();
        _InputDeviceLayout.PlayerUI.Enable();
        _ProxyOpenGameMenu.ProxyOn();
    }

    public void UIButtonStart() {
        _InputDeviceLayout.Player.Enable();
        _InputDeviceLayout.PlayerUI.Disable();
        _ProxyOpenGameMenu.ProxyOff();
    }
}
