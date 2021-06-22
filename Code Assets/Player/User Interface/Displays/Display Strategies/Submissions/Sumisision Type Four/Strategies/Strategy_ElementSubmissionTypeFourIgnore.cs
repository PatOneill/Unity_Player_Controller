using System.Threading.Tasks;

public class Strategy_ElementSubmissionTypeFourIgnore : IUIElementSubmissionTypeFour {
    public Task SubmissionTypeFourStartAsync() {
        /*
         *@Desc: If a display implements this class, ignore any submission request to related to UI element
        */
        return Task.CompletedTask; ;
    }

    public void SubmissionTypeFourFinish() {
        /*
         *@Desc: If a display implements this class, ignore any submission request to related to UI element
        */
        return;
    }
}
