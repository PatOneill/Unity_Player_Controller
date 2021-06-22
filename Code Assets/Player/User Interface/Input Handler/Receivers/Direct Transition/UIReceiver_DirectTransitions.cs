public class UIReceiver_DirectTransitions : IUIActiveReceiver, IReceiverDirectTransitionHandler, IDirectTransitionGameMenu, IDirectTransitionPlayerMenu, IDirectTransitionBack {
    private bool _CanSendCommand;
    private IUIDirectTransitionMediator _ReceiverMediator;
    private ITransitionToGameMenu _DisplaysStrategyTransitionGameMenu;
    private ITransitionToPlayerMenu _DisplaysStrategyTransitionPlayerMenu;
    private ITransitionToPreviousDisplay _DisplaysStrategyTransitionBack;

    public bool IsUIReceivingInputCommands { set => _CanSendCommand = value; }
    public ITransitionToGameMenu SetGameMenuTransitionStrategy { set => _DisplaysStrategyTransitionGameMenu = value; }
    public ITransitionToPlayerMenu SetPlayerMenuTransitionStrategy { set => _DisplaysStrategyTransitionPlayerMenu = value; }
    public ITransitionToPreviousDisplay SetBackTransitionStrategy { set => _DisplaysStrategyTransitionBack = value; }

    public UIReceiver_DirectTransitions(IUIDirectTransitionMediator receiverMediator) {
        receiverMediator.SetDirectTransitionReceiver = this;
        _ReceiverMediator = receiverMediator;
        _CanSendCommand = true;
        _DisplaysStrategyTransitionGameMenu = null;
        _DisplaysStrategyTransitionPlayerMenu = null;
        _DisplaysStrategyTransitionBack = null;
    }

    public void TransitionToGameMenu() {
        /*
         *@Desc: Inform the active display that the user wants to transition to the display of game menu
         *@NOTE: This method does not guarantee that the game menu is actually be display
        */
        if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
            _ReceiverMediator.DirectTransitionInactive(); //Inform certain other commands that they can no longer run until this direct transition command become inactive
            _DisplaysStrategyTransitionGameMenu.TransitionToGameMenu();
            _ReceiverMediator.DirectTransitionInactive(); //Inform other commands that they are now allow to run
        }
    }

    public void TransitionToPlayerMenu() {
        /*
         *@Desc: Inform the active display that the user wants to transition to the display of player menu
         *@NOTE: This method does not guarantee that the player menu is actually be display
        */
        if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
            _ReceiverMediator.DirectTransitionInactive(); //Inform certain other commands that they can no longer run until this direct transition command become inactive
            _DisplaysStrategyTransitionPlayerMenu.TransitionToPlayerMenu();
            _ReceiverMediator.DirectTransitionInactive(); //Inform other commands that they are now allow to run
        }
    }

    public void TransitionToBack() {
        /*
         *@Desc: Inform the active display that the user wants to transition to the previous display
         *@NOTE: This method does not guarantee that the player's current active display will change
        */
        if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
            _ReceiverMediator.DirectTransitionInactive(); //Inform certain other commands that they can no longer run until this direct transition command become inactive
            _DisplaysStrategyTransitionBack.TransitionToBack();
            _ReceiverMediator.DirectTransitionInactive(); //Inform other commands that they are now allow to run
        }
    }
}
