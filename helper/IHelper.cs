namespace Prac.helper;

public interface IHelper {
    void Quest(string question);

    string SubmitUrl();

    Task GoTo(string url);

    Task Picker(List<string> li);
}