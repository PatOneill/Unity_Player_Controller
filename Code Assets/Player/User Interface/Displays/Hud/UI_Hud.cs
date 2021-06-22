using UnityEngine;

public class UI_Hud : ADisplayReceivers, IDisplayUI {
    private GameObject _HudDisplay;
    private ISwapperMediator _InputSwapper;
    private IGetReceiverFunctionality _InputReceiver;

    public UI_Hud(GameObject display, ISwapperMediator inputSwapper, IGetReceiverFunctionality inputReceivers, UI_DisplayTransitions transitions) {
        _HudDisplay = display;
        _InputSwapper = inputSwapper;
        _InputReceiver = inputReceivers;
        SetupInputReceivers(inputReceivers, transitions);
    }

    protected override void SetupInputReceivers(IGetReceiverFunctionality inputReceivers, UI_DisplayTransitions transitions) {
        IReceiverDirectTransitionHandler directTransitionHandler = inputReceivers.GetDirectTransitionReceiver;
        directTransitionHandler.SetGameMenuTransitionStrategy = new Strategy_GameMenuTransitionGoTo(transitions);
        directTransitionHandler.SetPlayerMenuTransitionStrategy = new Strategy_PlayerMenuTransitionGoTo(transitions);
    }

    public void ShowDisplay() {
        /*
         *@Desc: Shows the user the Hud display for the player, and whenever the Hud is displayed ensure that the current input action map is set to Gameplay Input Action Map
        */
        _InputSwapper.SwapToGamePlayIAM();
        _HudDisplay.SetActive(true);
    }

    public void HideDisplay() {
        /*
         *@Desc: Hides the Hud display for the player from the user, and whenever the Hud is hidden ensure that the current input action map is set to User Interface Input Action Map
        */
        _HudDisplay.SetActive(false);
        _InputSwapper.SwapToUserInterfaceIAM();
    }
}
