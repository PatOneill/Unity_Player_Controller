public class UI_InputHandler : IGetReceiverFunctionality, IUINavigationCommands, IUIDirectTransitionCommands, IUISubmitCommands, IUISubWindowShiftCommands {
    private Timer _UIEventDelayer;
    private UIReceiver_Mediator _UIReceiverMediator;

    private UIReceiver_ElementNavigation _UIElementNavigationReceiver;
    private UIReceiver_DirectTransitions _UIDirectTransitionsReceiver;
    private UIReceiver_ElementSubmit _UIElementSubmitReceiver;
    private UIReceiver_SubWindowShift _UISubWindowShiftReceiver;

    #region Command Variables
    private IUINavigateCommand _UpCommand;
    private IUINavigateCommand _DownCommand;
    private IUINavigateCommand _LeftCommand;
    private IUINavigateCommand _RightCommand;
    private IUIIrreversibleCommand _GameMenuDirectTransition;
    private IUIIrreversibleCommand _PlayerMenuDirectTransition;
    private IUIIrreversibleCommand _BackDirectTransition;
    private IUIIrreversibleCommand _SubmitTypeOne;
    private IUIIrreversibleCommand _SubmitTypeTwo;
    private IUIIrreversibleCommand _SubmitTypeThree;
    private IUICommand _SubmitTypeFour;
    private IUIIrreversibleCommand _ShiftSubWindowLeft;
    private IUIIrreversibleCommand _ShiftSubWindowRight;
    #endregion
    #region Command Get Methods
    public IUINavigateCommand GetUpCommand => _UpCommand;
    public IUINavigateCommand GetDownCommand => _DownCommand;
    public IUINavigateCommand GetRightCommand => _LeftCommand;
    public IUINavigateCommand GetLeftCommand => _RightCommand;
    public IUIIrreversibleCommand GetGameMenuTransitionCommand => _GameMenuDirectTransition;
    public IUIIrreversibleCommand GetPlayerMenuTransitionCommand => _PlayerMenuDirectTransition;
    public IUIIrreversibleCommand GetBackTransitionCommand => _BackDirectTransition;
    public IUIIrreversibleCommand GetSubmissionTypeOneCommand => _SubmitTypeOne;
    public IUIIrreversibleCommand GetSubmissonTypeTwoCommand => _SubmitTypeTwo;
    public IUIIrreversibleCommand GetSubmissionTypeThreeCommand => _SubmitTypeThree;
    public IUICommand GetSubmissionTypeFourCommand => _SubmitTypeFour;
    public IUIIrreversibleCommand GetSubWindowShiftLeftCommand => _ShiftSubWindowLeft;
    public IUIIrreversibleCommand GetSubWindowShiftRightCommand => _ShiftSubWindowRight;
    #endregion

    public IReceiverDirectTransitionHandler GetDirectTransitionReceiver => _UIDirectTransitionsReceiver;
    public IReceiverHandleElementNavigation GetUIElementNavigationReceiver => _UIElementNavigationReceiver;
    public IReceiverHandleElementSubmission GetUIElementSubmissionReceiver => _UIElementSubmitReceiver;
    public IReceiverHandlerSubWindowNavigation GetSubWindowNavigation => _UISubWindowShiftReceiver;

    public UI_InputHandler() {
        _UIEventDelayer = new Timer(0.25f);
        _UIReceiverMediator = new UIReceiver_Mediator();

        _UIElementNavigationReceiver = new UIReceiver_ElementNavigation(_UIReceiverMediator, _UIEventDelayer);
        _UpCommand = new UI_NavigateUpCommand(_UIElementNavigationReceiver);
        _DownCommand = new UI_NavigateDownCommand(_UIElementNavigationReceiver);
        _LeftCommand = new UI_NavigateLeftCommand(_UIElementNavigationReceiver);
        _RightCommand = new UI_NavigateRightCommand(_UIElementNavigationReceiver);

        _UIDirectTransitionsReceiver = new UIReceiver_DirectTransitions(_UIReceiverMediator);
        _GameMenuDirectTransition = new UI_TransitionToGameMenu(_UIDirectTransitionsReceiver);
        _PlayerMenuDirectTransition = new UI_TransitionToPlayerMenu(_UIDirectTransitionsReceiver);
        _BackDirectTransition = new UI_TransitionToBack(_UIDirectTransitionsReceiver);

        _UIElementSubmitReceiver = new UIReceiver_ElementSubmit(_UIReceiverMediator);
        _SubmitTypeOne = new UI_SubmitTypeOneCommand(_UIElementSubmitReceiver);
        _SubmitTypeTwo = new UI_SubmitTypeTwoCommand(_UIElementSubmitReceiver);
        _SubmitTypeThree = new UI_SubmitTypeThreeCommand(_UIElementSubmitReceiver);
        _SubmitTypeFour = new UI_SubmitTypeFourCommand(_UIElementSubmitReceiver);

        _UISubWindowShiftReceiver = new UIReceiver_SubWindowShift(_UIReceiverMediator);
        _ShiftSubWindowLeft = new UI_SubWindowShiftLeftCommand(_UISubWindowShiftReceiver);
        _ShiftSubWindowRight = new UI_SubWindowShiftRightCommand(_UISubWindowShiftReceiver);
    }

    public void RunNavigationCountDown() {
        /*
         *@Desc: Purposely delays the navigation input action events in the game's UI system (implemented for the sake of our slow human brains)
        */
        _UIEventDelayer.CountDown();
    }
}
