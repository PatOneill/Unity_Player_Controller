public interface IInputEventsUINavigationCommands {
    IInputUINavigationUpCommand GetInputUp { 
        get; 
    }

    IInputUINavigationDownCommand GetInputDown {
        get;
    }

    IInputUINavigationLeftCommand GetInputLeft {
        get;
    }

    IInputUINavigationRightCommand GetInputRight {
        get;
    }
}
