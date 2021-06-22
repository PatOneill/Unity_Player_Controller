using System.Threading.Tasks;
public class Strategy_ElementSubmissionTypeOneIgnore : IUIElementSubmissionTypeOne {
    public Task SubmissionTypeOneAsync() {
        /*
         *@Desc: If a display implements this class, ignore any submission request to related to UI element
        */
        return Task.CompletedTask;
    }
}
