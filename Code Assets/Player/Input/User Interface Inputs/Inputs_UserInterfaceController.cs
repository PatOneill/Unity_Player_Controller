using UnityEngine;

public class Inputs_UserInterfaceController : IInputEventsUINavigationCommands, IInputEventsUISubmissionCommands, IInputUIDirectTransitionBackCommands, IInputEventsUISubWindowCommands {
    private AnalogInputEventObservable _MoveCursorObserver;

    private InputEvent_MoveCursor _InputEventMoveCursor;
    private InputEvent_Up _InputEventUp;
    private InputEvent_Down _InputEventDown;
    private InputEvent_Left _InputEventLeft;
    private InputEvent_Right _InputEventRight;
    private InputEvent_Back _InputEventBack;
    private InputEvent_SubmitTypeOne _InputEventSubmitTypeOne;
    private InputEvent_SubmitTypeTwo _InputEventSubmitTypeTwo;
    private InputEvent_SubmitTypeThree _InputEventSubmitTypeThree;
    private InputEvent_SubmitTypeFour _InputEventSubmitTypeFour;
    private InputEvent_ShiftSubWindowLeft _InputEventShiftSubWindowLeft;
    private InputEvent_ShiftSubWindowRight _InputEventShiftSubWindowRight;

    public IInputUINavigationUpCommand GetInputUp => _InputEventUp;
    public IInputUINavigationDownCommand GetInputDown => _InputEventDown;
    public IInputUINavigationLeftCommand GetInputLeft => _InputEventLeft;
    public IInputUINavigationRightCommand GetInputRight => _InputEventRight;
    public IInputSubmissionTypeOneCommand GetInputSubmitTypeOne => _InputEventSubmitTypeOne;
    public IInputSubmissionTypeTwoCommand GetInputSubmitTypeTwo => _InputEventSubmitTypeTwo;
    public IInputSubmissionTypeThreeCommand GetInputSubmitTypeThree => _InputEventSubmitTypeThree;
    public IInputSubmissionTypeFourCommand GetInputSubmitTypeFour => _InputEventSubmitTypeFour;
    public IInputUITransitionBackCommand GetInputBack => _InputEventBack;
    public IInputUISubWindowShiftLeftCommand GetInputShiftSubWindowLeft => _InputEventShiftSubWindowLeft;
    public IInputUISubWindowShiftRightCommand GetInputShiftSubWindowRight => _InputEventShiftSubWindowRight;

    public Inputs_UserInterfaceController(PlayerInputs inputDevice) {
        _MoveCursorObserver = new AnalogInputEventObservable();

        _InputEventMoveCursor = new InputEvent_MoveCursor(_MoveCursorObserver);
        #region MoveCursor Input Event Setup
        inputDevice.UserInterfaceInput.MoveCursor.started += CallbackContext => _InputEventMoveCursor.AnalogInputEventStart(CallbackContext.ReadValue<Vector2>());
        inputDevice.UserInterfaceInput.MoveCursor.performed += CallbackContext => _InputEventMoveCursor.AnalogInputEventPerform(CallbackContext.ReadValue<Vector2>());
        inputDevice.UserInterfaceInput.MoveCursor.canceled += CallbackContext => _InputEventMoveCursor.AnalogInputEventCancel();
        #endregion
        _InputEventUp = new InputEvent_Up();
        #region Navigate Up Input Event Setup
        inputDevice.UserInterfaceInput.Up.started += CallbackContext => _InputEventUp.HoldInputEventStart(CallbackContext.ReadValue<float>());
        inputDevice.UserInterfaceInput.Up.performed += CallbackContext => _InputEventUp.HoldInputEventPeform(CallbackContext.ReadValue<float>());
        inputDevice.UserInterfaceInput.Up.canceled += CallbackContext => _InputEventUp.HoldInputEventCancel();
        #endregion
        _InputEventDown = new InputEvent_Down();
        #region Navigate Down Input Event Setup
        inputDevice.UserInterfaceInput.Down.started += CallbackContext => _InputEventDown.HoldInputEventStart(CallbackContext.ReadValue<float>());
        inputDevice.UserInterfaceInput.Down.performed += CallbackContext => _InputEventDown.HoldInputEventPeform(CallbackContext.ReadValue<float>());
        inputDevice.UserInterfaceInput.Down.canceled += CallbackContext => _InputEventDown.HoldInputEventCancel();
        #endregion
        _InputEventLeft = new InputEvent_Left();
        #region Navigate Left Input Event Setup
        inputDevice.UserInterfaceInput.Left.started += CallbackContext => _InputEventLeft.HoldInputEventStart(CallbackContext.ReadValue<float>());
        inputDevice.UserInterfaceInput.Left.performed += CallbackContext => _InputEventLeft.HoldInputEventPeform(CallbackContext.ReadValue<float>());
        inputDevice.UserInterfaceInput.Left.canceled += CallbackContext => _InputEventLeft.HoldInputEventCancel();
        #endregion
        _InputEventRight = new InputEvent_Right();
        #region Navigate Right Input Event Setup
        inputDevice.UserInterfaceInput.Right.started += CallbackContext => _InputEventRight.HoldInputEventStart(CallbackContext.ReadValue<float>());
        inputDevice.UserInterfaceInput.Right.performed += CallbackContext => _InputEventRight.HoldInputEventPeform(CallbackContext.ReadValue<float>());
        inputDevice.UserInterfaceInput.Right.canceled += CallbackContext => _InputEventRight.HoldInputEventCancel();
        #endregion
        _InputEventBack = new InputEvent_Back();
        #region Navigate Window Back Input Event Setup
        inputDevice.UserInterfaceInput.Back.canceled += CallbackContext => _InputEventBack.ButtonInputEventCanceled();
        #endregion
        _InputEventSubmitTypeOne = new InputEvent_SubmitTypeOne();
        #region Submit Type One Input Event Setup
        inputDevice.UserInterfaceInput.SubmitTypeOne.canceled += CallbackContext => _InputEventSubmitTypeOne.ButtonInputEventCanceled();
        #endregion
        _InputEventSubmitTypeTwo = new InputEvent_SubmitTypeTwo();
        #region Submit Type Two Input Event Setup
        inputDevice.UserInterfaceInput.SubmitTypeTwo.canceled += CallbackContext => _InputEventSubmitTypeTwo.ButtonInputEventCanceled();
        #endregion
        _InputEventSubmitTypeThree = new InputEvent_SubmitTypeThree();
        #region Submit Type Three Input Event Setup
        inputDevice.UserInterfaceInput.SubmitTypeThree.canceled += CallbackContext => _InputEventSubmitTypeThree.ButtonInputEventCanceled();
        #endregion
        _InputEventSubmitTypeFour = new InputEvent_SubmitTypeFour();
        #region Submit Type Four Input Event Setup
        inputDevice.UserInterfaceInput.SubmitTypeFour.started += CallbackContext => _InputEventSubmitTypeFour.ButtonInputEventStarted();
        inputDevice.UserInterfaceInput.SubmitTypeFour.canceled += CallbackContext => _InputEventSubmitTypeFour.ButtonInputEventCanceled();
        #endregion
        _InputEventShiftSubWindowLeft = new InputEvent_ShiftSubWindowLeft();
        #region Shift Sub Window Left Input Event Setup
        inputDevice.UserInterfaceInput.ShiftSubWindowLeft.canceled += CallbackContext => _InputEventShiftSubWindowLeft.ButtonInputEventCanceled();
        #endregion
        _InputEventShiftSubWindowRight = new InputEvent_ShiftSubWindowRight();
        #region Shift Sub Window Right Input Event Setup
        inputDevice.UserInterfaceInput.ShiftSubWindowRight.canceled += CallbackContext => _InputEventShiftSubWindowRight.ButtonInputEventCanceled();
        #endregion
    }
}
