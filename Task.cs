public class Task
{
    public int ID {get; private set;}
    public string Title {get; private set;}
    public string Description {get; private set;}
    public bool isCompleted {get; set;}

    public Task(int id, string title, string description, bool _isCompleted)
    {
        ID = id;
        Title = title;
        Description = description;
        isCompleted = _isCompleted;
    }


    public void DisplayTask()
    {
        if(isCompleted)
        {
            Console.WriteLine($"[x] {ID}    {Title}");
        }
        else
        {
            Console.WriteLine($"[ ] {ID}    {Title}");
        }
    }

    public void DisplayDescription()
    {
        Console.WriteLine($"    -{Description}");
    }

}