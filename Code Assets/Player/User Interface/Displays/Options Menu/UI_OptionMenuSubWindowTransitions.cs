using UnityEngine;

public class UI_OptionMenuSubWindowTransitions : ISubWindowDisplayTransitions {
    private ISubWindowDisplayUI _ActiveSubWindowDisplay;
    private OptionsGameplaySubWindow _SubWindowGameplay;
    private OptionsVideoSubWindow _SubWindowVideo;
    private OptionsSoundSubWindow _SubWindowSound;
    private OptionsControlsSubWindow _SubWindowControls;

    public UI_OptionMenuSubWindowTransitions(GameObject optionsDisplay, GameObject optionsDisplayMenuBar, IGetReceiverFunctionality inputReceivers) {
        _SubWindowGameplay = new OptionsGameplaySubWindow(optionsDisplay.transform.Find("Gameplay Window").gameObject, optionsDisplayMenuBar.transform.Find("Gameplay").gameObject, inputReceivers, this);
        _SubWindowVideo = new OptionsVideoSubWindow(optionsDisplay.transform.Find("Video Window").gameObject, optionsDisplayMenuBar.transform.Find("Video").gameObject, inputReceivers, this);
        _SubWindowSound = new OptionsSoundSubWindow(optionsDisplay.transform.Find("Sound Window").gameObject, optionsDisplayMenuBar.transform.Find("Sound").gameObject, inputReceivers, this);
        _SubWindowControls = new OptionsControlsSubWindow(optionsDisplay.transform.Find("Controls Window").gameObject, optionsDisplayMenuBar.transform.Find("Controls").gameObject, inputReceivers, this);

        _SubWindowGameplay.SubWindowNavigationStrategy.SetupElementNavigation(leftElement: _SubWindowControls.SubWindowNavigationStrategy, rightElement: _SubWindowVideo.SubWindowNavigationStrategy);
        _SubWindowVideo.SubWindowNavigationStrategy.SetupElementNavigation(leftElement: _SubWindowGameplay.SubWindowNavigationStrategy, rightElement: _SubWindowSound.SubWindowNavigationStrategy);
        _SubWindowSound.SubWindowNavigationStrategy.SetupElementNavigation(leftElement: _SubWindowVideo.SubWindowNavigationStrategy, rightElement: _SubWindowControls.SubWindowNavigationStrategy);
        _SubWindowControls.SubWindowNavigationStrategy.SetupElementNavigation(leftElement: _SubWindowSound.SubWindowNavigationStrategy, rightElement: _SubWindowGameplay.SubWindowNavigationStrategy);

        SetupInputReceiver(inputReceivers);

        _ActiveSubWindowDisplay = _SubWindowGameplay; //When the options menu is displayed, the gameplay sub window will always be the default selected sub window
        _ActiveSubWindowDisplay.ShowSubWindowDisplay(); //When fully load, show the default display to the user
        
    }
    private void SetupInputReceiver(IGetReceiverFunctionality inputReceivers) {
        IReceiverHandlerSubWindowNavigation subWindowReceiver = inputReceivers.GetSubWindowNavigation;
        subWindowReceiver.SetUISubWindowNavigationStrategy = _SubWindowGameplay.SubWindowNavigationStrategy;
    }

    public void OnDisplay() {
        /*
         *@Desc: When the options menu is opened, set the gameplay sub window button as the default selected button
        */
        _SubWindowGameplay.SubWindowNavigationStrategy.SubWindowSelected();
    }

    public void OnClose() {
        /*
         *@Desc: When the options menu is closed, set the active sub window display to be disable. This ensure that upon next load functionality remains consistent
        */
        _ActiveSubWindowDisplay.HideSubWindowDisplay();
    }

    public void TransitionToGameplaySubWindow() {
        /*
         *@Desc: Transition to the sub window Gameplay in the Options Menu's display
        */
        _ActiveSubWindowDisplay.HideSubWindowDisplay();
        _ActiveSubWindowDisplay = _SubWindowGameplay;
        _ActiveSubWindowDisplay.ShowSubWindowDisplay();
    }

    public void TransitionToVideoSubWindow() {
        /*
         *@Desc: Transition to the sub window Video in the Options Menu's display
        */
        _ActiveSubWindowDisplay.HideSubWindowDisplay();
        _ActiveSubWindowDisplay = _SubWindowVideo;
        _ActiveSubWindowDisplay.ShowSubWindowDisplay();
    }

    public void TransitionToSoundSubWindow() {
        /*
         *@Desc: Transition to the sub window Sound in the Options Menu's display
        */
        _ActiveSubWindowDisplay.HideSubWindowDisplay();
        _ActiveSubWindowDisplay = _SubWindowSound;
        _ActiveSubWindowDisplay.ShowSubWindowDisplay();
    }

    public void TransitionToControlsSubWindow() {
        /*
         *@Desc: Transition to the sub window Controls in the Options Menu's display
        */
        _ActiveSubWindowDisplay.HideSubWindowDisplay();
        _ActiveSubWindowDisplay = _SubWindowControls;
        _ActiveSubWindowDisplay.ShowSubWindowDisplay();
    }
}
