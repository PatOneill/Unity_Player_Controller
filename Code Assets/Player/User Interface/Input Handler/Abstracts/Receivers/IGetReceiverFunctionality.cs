public interface IGetReceiverFunctionality {
    IReceiverDirectTransitionHandler GetDirectTransitionReceiver {
        get;
    }
    IReceiverHandleElementNavigation GetUIElementNavigationReceiver {
        get;
    }
    IReceiverHandleElementSubmission GetUIElementSubmissionReceiver {
        get;
    }
    IReceiverHandlerSubWindowNavigation GetSubWindowNavigation {
        get;
    }
}
