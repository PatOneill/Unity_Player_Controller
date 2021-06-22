public interface IUISubmitCommands {
    IUIIrreversibleCommand GetSubmissionTypeOneCommand {
        get;
    }

    IUIIrreversibleCommand GetSubmissonTypeTwoCommand {
        get;
    }

    IUIIrreversibleCommand GetSubmissionTypeThreeCommand {
        get;
    }

    IUICommand GetSubmissionTypeFourCommand {
        get;
    }
}
