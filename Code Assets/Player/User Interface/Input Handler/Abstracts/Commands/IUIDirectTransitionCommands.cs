public interface IUIDirectTransitionCommands {
    IUIIrreversibleCommand GetGameMenuTransitionCommand {
        get;
    }

    IUIIrreversibleCommand GetPlayerMenuTransitionCommand {
        get;
    }

    IUIIrreversibleCommand GetBackTransitionCommand {
        get;
    }
}
