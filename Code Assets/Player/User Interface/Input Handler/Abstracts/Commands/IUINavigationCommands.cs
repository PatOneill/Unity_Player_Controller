public interface IUINavigationCommands {
    IUINavigateCommand GetUpCommand {
        get;
    }

    IUINavigateCommand GetDownCommand {
        get;
    }

    IUINavigateCommand GetRightCommand {
        get;
    }

    IUINavigateCommand GetLeftCommand {
        get;
    }
}
