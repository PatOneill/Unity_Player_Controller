using UnityEngine;

public class PlayerMainFacade {
    private PlayerInputs _PlayerInputDevice;
    private Input_SwapperController _InputSwapperController;
    private Inputs_GameplayController _InputsGameplayController;
    private Inputs_GameplayAndUIController _InputsGameplayAndUIController;
    private Inputs_UserInterfaceController _InputsUserInterfaceController;
    private UI_InputHandler _UIInputHandler;
    private UI_DisplayTransitions _UIDisplayTransitions;

    public PlayerMainFacade(GameObject userInterface) {
        _PlayerInputDevice = new PlayerInputs();
        _InputSwapperController = new Input_SwapperController(_PlayerInputDevice);
        _InputsGameplayController = new Inputs_GameplayController(_PlayerInputDevice);
        _InputsGameplayAndUIController = new Inputs_GameplayAndUIController(_PlayerInputDevice);
        _InputsUserInterfaceController = new Inputs_UserInterfaceController(_PlayerInputDevice);

        _UIInputHandler = new UI_InputHandler();
        _UIDisplayTransitions = new UI_DisplayTransitions(userInterface, _InputSwapperController.GetMediator, _UIInputHandler);

        _InputsGameplayAndUIController.GetInputGameMenu.SetUITransitionGameMenuCommand = _UIInputHandler.GetGameMenuTransitionCommand;
        _InputsGameplayAndUIController.GetInputPlayMenu.SetUITransitionPlayerMenuCommand = _UIInputHandler.GetPlayerMenuTransitionCommand;
        _InputsUserInterfaceController.GetInputBack.SetUITransitionBackCommand = _UIInputHandler.GetBackTransitionCommand;

        _InputsUserInterfaceController.GetInputUp.SetUINavigationUpCommand = _UIInputHandler.GetUpCommand;
        _InputsUserInterfaceController.GetInputDown.SetUINavigationDownCommand = _UIInputHandler.GetDownCommand;
        _InputsUserInterfaceController.GetInputLeft.SetUINavigationLeftCommand = _UIInputHandler.GetLeftCommand;
        _InputsUserInterfaceController.GetInputRight.SetUINavigationRightCommand = _UIInputHandler.GetRightCommand;

        _InputsUserInterfaceController.GetInputSubmitTypeOne.SetSubmitTypeOneCommand = _UIInputHandler.GetSubmissionTypeOneCommand;
        _InputsUserInterfaceController.GetInputSubmitTypeTwo.SetSubmitTypeTwoCommand = _UIInputHandler.GetSubmissonTypeTwoCommand;
        _InputsUserInterfaceController.GetInputSubmitTypeThree.SetSubmitTypeThreeCommand = _UIInputHandler.GetSubmissionTypeThreeCommand;
        _InputsUserInterfaceController.GetInputSubmitTypeFour.SetSubmitTypeFourCommand = _UIInputHandler.GetSubmissionTypeFourCommand;

        _InputsUserInterfaceController.GetInputShiftSubWindowLeft.SetSubWindowShiftLeftCommand = _UIInputHandler.GetSubWindowShiftLeftCommand;
        _InputsUserInterfaceController.GetInputShiftSubWindowRight.SetSubWindowShiftRightCommand = _UIInputHandler.GetSubWindowShiftRightCommand;

        _InputSwapperController.ActivateOnlyGameplayActionMap(); //When the player gameobject fully loads in, the gameplay input action map will be monitoring the users inputs
    }

    public void FacadeStart() {
        
    }

    public void FacadeFixedUpdate() {
        
    }

    public void FacadeUpdate() {
        _UIInputHandler.RunNavigationCountDown();
    }

    public void FacadeLateUpdate() {
        _InputSwapperController.CheckForSwapRequest();
    }
}
