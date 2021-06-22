using System;

public class Input_SwapperController : IInputSwapperMediator, IUserInterfaceSwapper, ICinematicSwapper {
    private PlayerInputs _PlayerInputDevice;
    private SwapperMediator _InputSwapperMediator;
    private Action _SwapIAMMethod;
    private bool _SwapRequested;

    public ISwapperMediator GetMediator => _InputSwapperMediator;

    public Input_SwapperController(PlayerInputs inputDevice) {
        _PlayerInputDevice = inputDevice;
        _InputSwapperMediator = new SwapperMediator(this);
        _SwapRequested = false;
    }

    public void CheckForSwapRequest() {
        /*
         * @Desc: On late update check to see if an external class has request that the input system change the current active IAM
        */
        if (_SwapRequested) {
            _SwapIAMMethod();
            _SwapRequested = false;
        }
    }

    public void SwapToGameplayActionMap() {
        /*
         * @Desc: Notifies the class that the input action map needs to switch to gameplay input
        */
        _SwapRequested = true;
        _SwapIAMMethod = SwapToIAMGameplay;
    }

    public void SwapToUserInterfaceActionMap() {
        /*
         * @Desc: Notifies the class that the input action map needs to switch to userinterface input
        */
        _SwapRequested = true;
        _SwapIAMMethod = SwapToIAMUserInterface;
    }

    public void ActivateOnlyGameplayActionMap() {
        /*
         * @Desc: Notifies the class that the input action map gameplay input needs to be enabled
        */
        _SwapRequested = true;
        _SwapIAMMethod = ActivateIAMGameplay;
    }

    public void DisableAllActionMaps() {
        /*
         * @Desc: Notifies the class that all input action maps needs to be disabled
        */
        _SwapRequested = true;
        _SwapIAMMethod = DisableAllIAM;
    }

    private void SwapToIAMGameplay() {
        /*
         * @Desc: Disables the IAM UserInterfaceInput and enables IAM GameplayInput
        */
        _PlayerInputDevice.UserInterfaceInput.Disable();
        _PlayerInputDevice.GameplayInput.Enable();
        _SwapIAMMethod -= SwapToIAMGameplay;
    }

    private void SwapToIAMUserInterface() {
        /*
          * @Desc: Disables the IAM GameplayInput and enables IAM UserInterfaceInput
        */
        _PlayerInputDevice.GameplayInput.Disable();
        _PlayerInputDevice.UserInterfaceInput.Enable();
        _SwapIAMMethod -= SwapToIAMUserInterface;
    }

    private void ActivateIAMGameplay() {
        /*
          * @Desc: Activate the IAM of gameplay input
        */
        _PlayerInputDevice.GameplayInput.Enable();
        _SwapIAMMethod -= ActivateIAMGameplay;
    }

    private void DisableAllIAM() {
        /*
          * @Desc: Disables all IAM 
        */
        _PlayerInputDevice.Disable();
        _SwapIAMMethod -= DisableAllIAM;
    }
}
