public class Task
{
    public string _title {get; set;}

    public bool isCompleted {get; set;}

    public CompletionStatus completionStatus {get; set;}

    public Task(string title, bool _isCompleted)
    {
        _title = title;
        isCompleted = _isCompleted;
    }

    public string Title()
    {
        return _title;
    }

    public string SetTitle(string newTitle)
    {
        _title = newTitle;
        return _title;
    }


    public void DisplayTask()
    {
        if(isCompleted)
        {
            Console.WriteLine($"[x]    {Title}");
        }
        else
        {
            Console.WriteLine($"[ ]    {Title}");
        }
    }

    public CompletionStatus Status()
    {
        if(isCompleted)
        {
            return CompletionStatus.Done;
        }
        else
        {
            return CompletionStatus.NotDone;
        }
    }

    public void ToggleStatus()
    {
        isCompleted = !isCompleted;
    }

}
public enum CompletionStatus {Done, NotDone};