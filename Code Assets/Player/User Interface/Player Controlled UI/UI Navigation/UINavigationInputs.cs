public class UINavigationInputs : IUINavigationCommands {
    private IUIControllerNavigationCommands _CurrentUIDisplay;

    public IUIControllerNavigationCommands CurrentUIDisplay { set => _CurrentUIDisplay = value; }

    public UINavigationInputs() {
        _CurrentUIDisplay = null;
    }

    public void NavigateUp() {
        /**
          * @desc Request that the current active UI display changes the current the selected UI element by one in the upper direction (if possible)
        */
        _CurrentUIDisplay.NavigateVertically(1);
    }

    public void NavigateDown() {
        /**
          * @desc Request that the current active UI display changes the current the selected UI element by one in the downward direction (if possible)
        */
        _CurrentUIDisplay.NavigateVertically(-1);
    }

    public void NavigateLeft() {
        /**
          * @desc Request that the current active UI display changes the current the selected UI element by one in the leftward direction (if possible)
        */
        _CurrentUIDisplay.NavigateHorizontally(-1);
    }

    public void NavigateRight() {
        /**
          * @desc Request that the current active UI display changes the current the selected UI element by one in the rightward direction (if possible)
        */
        _CurrentUIDisplay.NavigateHorizontally(1);
    }

    public void NavigateSubmit() {
        /**
          * @desc Request that the current active UI display executes the current the selected UI element primary function
        */
        _CurrentUIDisplay.NavigateSelectablePressed();
    }
}
