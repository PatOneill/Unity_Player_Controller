public class UIReceiver_ElementSubmit : IReceiverHandleElementSubmission, IUIActiveReceiver, IElementSubmitTypeOneCommand, IElementSubmitTypeTwoCommand, IElementSubmitTypeThreeCommand, IElementSubmitTypeFourCommand {
    private bool _CanSendCommand;
    private IUISubmitMediator _ReceiverMediator;
    private IUIElementSubmissionTypeOne _DisplayStrategySubmissionTypeOne;
    private IUIElementSubmissionTypeTwo _DisplayStrategySubmissionTypeTwo;
    private IUIElementSubmissionTypeThree _DisplayStrategySubmissionTypeThree;
    private IUIElementSubmissionTypeFour _DisplayStrategySubmissionTypeFour;

    public bool IsUIReceivingInputCommands { set => _CanSendCommand = value; }
    public IUIElementSubmissionTypeOne SetUIElementSubmissionTypeOneStrategy { set => _DisplayStrategySubmissionTypeOne = value; }
    public IUIElementSubmissionTypeTwo SetUIElementSubmissionTypeTwoStrategy { set => _DisplayStrategySubmissionTypeTwo = value; }
    public IUIElementSubmissionTypeThree SetUIElementSubmissionTypeThreeStrategy { set => _DisplayStrategySubmissionTypeThree = value; }
    public IUIElementSubmissionTypeFour SetUIElementSubmissionTypeFourStrategy { set => _DisplayStrategySubmissionTypeFour = value; }

    public UIReceiver_ElementSubmit(IUISubmitMediator receiverMediator) {
        receiverMediator.SetSubmissionReceiver = this;
        _ReceiverMediator = receiverMediator;
        _CanSendCommand = true;
        _DisplayStrategySubmissionTypeOne = null;
        _DisplayStrategySubmissionTypeTwo = null;
        _DisplayStrategySubmissionTypeThree = null;
        _DisplayStrategySubmissionTypeFour = null;
    }

    public async void SubmitTypeOneEvent() {
        if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
            _ReceiverMediator.SubmissionActive(); //Inform certain other commands that they can no longer run until this submission command become inactive
            await _DisplayStrategySubmissionTypeOne.SubmissionTypeOneAsync();
            _ReceiverMediator.SubmissionInactive(); //Inform other commands that they are now allow to run
        }
    }
    
    public async void SubmitTypeTwoEvent() {
        if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
            _ReceiverMediator.SubmissionActive(); //Inform certain other commands that they can no longer run until this submission command become inactive
            await _DisplayStrategySubmissionTypeTwo.SubmissionTypeTwoAsync();
            _ReceiverMediator.SubmissionInactive(); //Inform other commands that they are now allow to run
        }
    }
    
    public async void SubmitTypeThreeEvent() {
        if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
            _ReceiverMediator.SubmissionActive(); //Inform certain other commands that they can no longer run until this submission command become inactive
            await _DisplayStrategySubmissionTypeThree.SubmissionTypeThreeAsync();
            _ReceiverMediator.SubmissionInactive(); //Inform other commands that they are now allow to run
        }
    }
    
    #region Submit Type Four Events
    public async void SubmitTypeFourStartEvent() {
        if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
            _ReceiverMediator.SubmissionActive(); //Inform certain other commands that they can no longer run until this submission command become inactive
            await _DisplayStrategySubmissionTypeFour.SubmissionTypeFourStartAsync();
        }
    }

    public void SubmitTypeFourEndEvent() {
        _ReceiverMediator.SubmissionInactive(); //Inform other commands that they are now allow to run
        _DisplayStrategySubmissionTypeFour.SubmissionTypeFourFinish();
    }
    #endregion
}
