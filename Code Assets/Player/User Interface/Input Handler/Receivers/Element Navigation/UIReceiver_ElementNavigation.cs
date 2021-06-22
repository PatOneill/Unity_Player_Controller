using System.Collections.Generic;
using System;

public class UIReceiver_ElementNavigation : IUIActiveReceiver, IReceiverHandleElementNavigation, IDirectionalCommandUp, IDirectionalCommandDown, IDirectionalCommandLeft, IDirectionalCommandRight {
    private bool _CanSendCommand;
    private IUINavigationMediator _ReceiverMediator;
    private IUIElementNavigation _DisplayStrategyUIElementNavigation;
    private float _ActivationThreshold;
    private IUITimerDelayer _UIInputEventDelayer;
    private Action _UpDelegate;
    private Action _DownDelegate;
    private Action _LeftDelegate;
    private Action _RightDelegate;
    List<Action> _UIElementNavigation;

    public bool IsUIReceivingInputCommands { set => _CanSendCommand = value; }
    public IUIElementNavigation SetUIElementNavigationStrategy { set => _DisplayStrategyUIElementNavigation = value; }
    public UIReceiver_ElementNavigation(IUINavigationMediator receiverMediator, IUITimerDelayer timeDelayerController) {
        receiverMediator.SetNavigationReceiver = this;
        _ReceiverMediator = receiverMediator;
        _CanSendCommand = true;
        _DisplayStrategyUIElementNavigation = null;
        _ActivationThreshold = 0.8f;
        _UIInputEventDelayer = timeDelayerController;
        _UIElementNavigation = new List<Action>();
    }

    #region Select Up Element
    public void MoveSelectedUIElementUp(float pressValue) {
        /*
         * @Desc: Check to ensure that all requirements are met before allowing the navigate up command to be sent to the current active UI's selected element
         * @Param: float pressValue - This parameter represents the current position of the analog stick and or button on the user's controller.
        */
        if (_ActivationThreshold > pressValue) { //The position of the button or analog stick is not significant enough to trigger the current event
            CancelSelectedUpCommand(); //If requirements are not met, check for unsubscribe case in the delegate to ensure multiple events are not execute sequentially
            return; 
        } 

        if (_UpDelegate == null) { //Ensure that only one Action is set for the command navigate up
            if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
                _ReceiverMediator.NavigationActive(); //Inform certain other commands that they can no longer run until all navigation commands become inactive
                _UpDelegate = this.SelectUpElement;
                AddNavigationEvent(_UpDelegate);
            }
        }
    }

    public void CancelSelectedUpCommand() {
        /*
         * @Desc: If requirements are unmet for the up command, unsubscribe from the Action delegate
        */
        if (_UpDelegate != null) {
            RemoveNavigationEvent(_UpDelegate);
            _UpDelegate -= this.SelectUpElement;
            if (_UIElementNavigation.Count == 0) { //Check to ensure that no navigation commands are in queue
                _ReceiverMediator.NavigationInactive(); //Inform other commands that they are now allow to run
            }
        }
    }

    private void SelectUpElement() {
        /*
         * @Desc: This method will inform the currently selected button that it needs to shift up (if possible)
         * @NOTE: This method will be converted into a delegate and will be called with a slight delay
        */
        _DisplayStrategyUIElementNavigation.NavigateUp();
    }
    #endregion
    #region Select Down Element
    public void MoveSelectedUIElementDown(float pressValue) {
        /*
         * @Desc: Check to ensure that all requirements are met before allowing the navigate down command to be sent to the current active UI's selected element
         * @Param: float pressValue - This parameter represents the current position of the analog stick and or button on the user's controller.
        */
        if (_ActivationThreshold > pressValue) { //The position of the button or analog stick is not significant enough to trigger the current event
            CancelSelectedDownCommand(); //If requirements are not met, check for unsubscribe case in the delegate to ensure multiple events are not execute sequentially
            return;
        }

        if (_DownDelegate == null) { //Ensure that only one Action is set for the command navigate up
            if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
                _ReceiverMediator.NavigationActive(); //Inform certain other commands that they can no longer run until all navigation commands become inactive
                _DownDelegate = this.SelectDownElement;
                AddNavigationEvent(_DownDelegate);
            }
        }
    }

    public void CancelSelectedDownCommand() {
        /*
         * @Desc: If requirements are unmet for the down command, unsubscribe from the Action delegate
        */
        if (_DownDelegate != null) {
            RemoveNavigationEvent(_DownDelegate);
            _DownDelegate -= this.SelectDownElement;
            if (_UIElementNavigation.Count == 0) { //Check to ensure that no navigation commands are in queue
                _ReceiverMediator.NavigationInactive(); //Inform other commands that they are now allow to run
            }
        }
    }

    private void SelectDownElement() {
        /*
         * @Desc: This method will inform the currently selected button that it needs to shift down (if possible)
         * @NOTE: This method will be converted into a delegate and will be called with a slight delay
        */
        _DisplayStrategyUIElementNavigation.NavigateDown();
    }
    #endregion
    #region Select Left Element
    public void MoveSelectedUIElementLeft(float pressValue) {
        /*
         * @Desc: Check to ensure that all requirements are met before allowing the navigate left command to be sent to the current active UI's selected element
         * @Param: float pressValue - This parameter represents the current position of the analog stick and or button on the user's controller.
        */
        if (_ActivationThreshold > pressValue) { //The position of the button or analog stick is not significant enough to trigger the current event
            CancelSelectedLeftCommand(); //If requirements are not met, check for unsubscribe case in the delegate to ensure multiple events are not execute sequentially
            return;
        }

        if (_LeftDelegate == null) { //Ensure that only one Action is set for the command navigate up
            if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
                _ReceiverMediator.NavigationActive(); //Inform certain other commands that they can no longer run until all navigation commands become inactive
                _LeftDelegate = this.SelectedLeftElement;
                AddNavigationEvent(_LeftDelegate);
            }
        }
    }

    public void CancelSelectedLeftCommand() {
        /*
         * @Desc: If requirements are unmet for the left command, unsubscribe from the Action delegate
        */
        if (_LeftDelegate != null) {
            RemoveNavigationEvent(_LeftDelegate);
            _LeftDelegate -= this.SelectedLeftElement;
            if (_UIElementNavigation.Count == 0) { //Check to ensure that no navigation commands are in queue
                _ReceiverMediator.NavigationInactive(); //Inform other commands that they are now allow to run
            }
        }
    }

    private void SelectedLeftElement() {
        /*
         * @Desc: This method will inform the currently selected button that it needs to shift left (if possible)
         * @NOTE: This method will be converted into a delegate and will be called with a slight delay
        */
        _DisplayStrategyUIElementNavigation.NavigateLeft();
    }
    #endregion
    #region Select Right Element
    public void MoveSelectedUIElementRight(float pressValue) {
        /*
         * @Desc: Check to ensure that all requirements are met before allowing the navigate right command to be sent to the current active UI's selected element
         * @Param: float pressValue - This parameter represents the current position of the analog stick and or button on the user's controller.
        */
        if (_ActivationThreshold > pressValue) { //The position of the button or analog stick is not significant enough to trigger the current event
            CancelSelectedRightCommand(); //If requirements are not met, check for unsubscribe case in the delegate to ensure multiple events are not execute sequentially
            return;
        }

        if (_RightDelegate == null) { //Ensure that only one Action is set for the command navigate right
            if (_CanSendCommand) { //Check to see if any other commands are running that could interfere with this command's functionality
                _ReceiverMediator.NavigationActive(); //Inform certain other commands that they can no longer run until all navigation commands become inactive
                _RightDelegate = this.SelectRightElement;
                AddNavigationEvent(_RightDelegate);
            }
        }
    }

    public void CancelSelectedRightCommand() {
        /*
         * @Desc: If requirements are unmet for the right command, unsubscribe from the Action delegate
        */
        if (_RightDelegate != null) {
            RemoveNavigationEvent(_RightDelegate);
            _RightDelegate -= this.SelectRightElement;
            if(_UIElementNavigation.Count == 0) { //Check to ensure that no navigation commands are in queue
                _ReceiverMediator.NavigationInactive(); //Inform other commands that they are now allow to run
            }
        }
    }

    private void SelectRightElement() {
        /*
         * @Desc: This method will inform the currently selected button that it needs to shift right (if possible)
         * @NOTE: This method will be converted into a delegate and will be called with a slight delay
        */
        _DisplayStrategyUIElementNavigation.NavigateRight();
    }
    #endregion

    private void AddNavigationEvent(Action inputEvent) {
        /*
         * @Desc: When a navigation command becomes active, add it to the queue and check to see if the delay timer needs a delegate, if so, pass the deligate to the delay timer
         * @Param: Action inputEvent - Holds the reference to the delegate of the newly activated command
        */
        if (_UIElementNavigation.Count == 0) {
            _UIElementNavigation.Add(inputEvent);
            _UIInputEventDelayer.ChangeCompletionEvent(inputEvent); //First element in the list will always be the active completion event in the timer 
        } else {
            _UIElementNavigation.Add(inputEvent);
        }
    }

    private void RemoveNavigationEvent(Action inputEvent) {
        /*
         * @Desc: When a navigation command becomes inactive, remove it to the queue and check to see if the queue can pass a new delegate to the delay timer, else clear the delay timer
         * @Param: Action inputEvent - Holds the reference to the delegate of the inactive command
        */
        int index = _UIElementNavigation.IndexOf(inputEvent);
        _UIElementNavigation.RemoveAt(index);
        if (index == 0) {
            if(_UIElementNavigation.Count > 0) {
                _UIInputEventDelayer.ChangeCompletionEvent(_UIElementNavigation[0]); //Set the next active navigation delegate as the upcoming completion event
            } else {
                _UIInputEventDelayer.ClearCompletionEvent(inputEvent); //No active events remain, so clear delay timer
            }
        }
    }
}
