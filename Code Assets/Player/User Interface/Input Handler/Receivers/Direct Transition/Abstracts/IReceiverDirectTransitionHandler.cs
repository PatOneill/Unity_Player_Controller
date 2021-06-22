public interface IReceiverDirectTransitionHandler {
    ITransitionToGameMenu SetGameMenuTransitionStrategy {
        set;
    }
    ITransitionToPlayerMenu SetPlayerMenuTransitionStrategy {
        set;
    }
    ITransitionToPreviousDisplay SetBackTransitionStrategy {
        set;
    }
}
