/*
 *@NOTE: This class should be use only for input events that are shared between both Gameplay and User Interface inputs
*/

public class Inputs_GameplayAndUIController : IInputEventsUIDirectTransitionCommands {
    private InputEvent_GameMenu _InputEventGameMenu;
    private InputEvent_PlayerMenu _InputEventPlayerMenu;

    public IInputUITransitionPlayerMenuCommand GetInputPlayMenu => _InputEventPlayerMenu;
    public IInputUITransitionGameMenuCommand GetInputGameMenu => _InputEventGameMenu;

    public Inputs_GameplayAndUIController(PlayerInputs inputDevice) {
        _InputEventGameMenu = new InputEvent_GameMenu();
        #region GameMenu Input Event Setup For Gameplay
        inputDevice.GameplayInput.GameMenu.canceled += CallbackContext => _InputEventGameMenu.ButtonInputEventCanceled();
        #endregion
        #region GameMenu Input Event Setup For User Interface
        inputDevice.UserInterfaceInput.GameMenu.canceled += CallbackContext => _InputEventGameMenu.ButtonInputEventCanceled();
        #endregion
        _InputEventPlayerMenu = new InputEvent_PlayerMenu();
        #region PlayerMenu Input Event Setup  For Gameplay
        inputDevice.GameplayInput.PlayerMenu.canceled += CallbackContext => _InputEventPlayerMenu.ButtonInputEventCanceled();
        #endregion
        #region PlayerMenu Input Event Setup For User Interface
        inputDevice.UserInterfaceInput.PlayerMenu.canceled += CallbackContext => _InputEventPlayerMenu.ButtonInputEventCanceled();
        #endregion
    }
}
