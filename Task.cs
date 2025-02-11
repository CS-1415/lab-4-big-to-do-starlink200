public class Task
{
    public string Title {get; private set;}

    public bool isCompleted {get; set;}

    public Task(string title, bool _isCompleted)
    {
        Title = title;
        isCompleted = _isCompleted;
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


}