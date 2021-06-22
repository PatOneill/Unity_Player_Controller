public class SwapperMediator : ISwapperMediator {
    private IUserInterfaceSwapper _InputSwapperController;
    private ICinematicSwapper _CinematicInputSwapperController;

    public SwapperMediator(Input_SwapperController swapperController) {
        _InputSwapperController = swapperController;
        _CinematicInputSwapperController = swapperController;
    }

    public void SwapToGamePlayIAM() {
        /*
         * @Desc: An External class needs to notifies the input swapper controller that the input action map needs to switch to gameplay input
        */
        _InputSwapperController.SwapToGameplayActionMap();
    }

    public void SwapToUserInterfaceIAM() {
        /*
         * @Desc: An External class needs to notifies the input swapper controller that the input action map needs to switch to user interface input
        */
        _InputSwapperController.SwapToUserInterfaceActionMap();
    }

    public void ActivateGameplayIAM() {
        /*
         * @Desc: An External class needs to notifies the input swapper controller that the input action map needs to activate to gameplay input
        */
        _CinematicInputSwapperController.ActivateOnlyGameplayActionMap();
    }

    public void DisableAllAM() {
        /*
         * @Desc: An External class needs to notifies the input swapper controller to disable all the input action maps
        */
        _CinematicInputSwapperController.DisableAllActionMaps();
    }
}
