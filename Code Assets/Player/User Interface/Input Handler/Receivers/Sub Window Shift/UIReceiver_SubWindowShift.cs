public class UIReceiver_SubWindowShift : IReceiverHandlerSubWindowNavigation, IUIActiveReceiver, ISubWindowShiftLeft, ISubWindowShiftRight {
    private bool _CanSendCommand;
    private IUISubWindowMediator _ReceiverMediator;
    private IUISubWindowNavigation _DisplayStrategySubWindowNavigation;
    public bool IsUIReceivingInputCommands { set => _CanSendCommand = value; }
    public IUISubWindowNavigation SetUISubWindowNavigationStrategy { set => _DisplayStrategySubWindowNavigation = value; }

    public UIReceiver_SubWindowShift(IUISubWindowMediator receiverMediator) {
        receiverMediator.SetSubWindowReceiver = this;
        _ReceiverMediator = receiverMediator;
        _CanSendCommand = true;
        _DisplayStrategySubWindowNavigation = null;
    }

    public void ShiftSubWindowLeft() {
        /*
         *@Desc: Check to ensure that all requirements are met before allowing the sub window left command to be sent to the current active UI's selected window
        */
        if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
            _ReceiverMediator.SubWindowActive(); //Inform certain other commands that they can no longer run until this sub window left command become inactive
            _DisplayStrategySubWindowNavigation.NavigateLeft();
            _ReceiverMediator.SubWindowInactive(); //Inform other commands that they are now allow to run
        }
    }

    public void ShiftSubWindowRight() {
        /*
         *@Desc: Check to ensure that all requirements are met before allowing the sub window right command to be sent to the current active UI's selected window
        */
        if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
            _ReceiverMediator.SubWindowActive(); //Inform certain other commands that they can no longer run until this sub window right command become inactive
            _DisplayStrategySubWindowNavigation.NavigateRight();
            _ReceiverMediator.SubWindowInactive(); //Inform other commands that they are now allow to run
        }
    }
}
