using System.Threading.Tasks;

public class Strategy_ElementSubmissionTypeTwoIgnore : IUIElementSubmissionTypeTwo {
    public Task SubmissionTypeTwoAsync() {
        /*
         *@Desc: If a display implements this class, ignore any submission request to related to UI element
        */
        return Task.CompletedTask; ;
    }
}
