using System.Runtime.InteropServices;

public class TodoList
{
    public List<Task> _taskList {get; set;}
    public int _cursorIndex {get; set;}

    public TodoList()
    {

    }
    public TodoList(List<Task> tasks, int cursorIndex)
    {
        _taskList = tasks;
        _cursorIndex = cursorIndex;
    }

    public Task Insert(string title)
    {
        Task newTask = new Task(title, false);
        return newTask;
    }

    public int PreviousIndex()
    {
        return _cursorIndex - 1;
    }

    public int NextIndex()
    {
        return _cursorIndex + 1;
    }

    public void SelectPrevious()
    {
        _cursorIndex--;
    }

    public void SelectNext()
    {
        _cursorIndex++;
    }
    public void SwapWithPrevious()
    {
        Task temp = _taskList[_cursorIndex];
        _taskList[_cursorIndex] = _taskList[_cursorIndex - 1];
        _taskList[_cursorIndex - 1] = temp;
    }

    public void SwapWithNext()
    {
        Task temp = _taskList[_cursorIndex];
        _taskList[_cursorIndex] = _taskList[_cursorIndex + 1];
        _taskList[_cursorIndex + 1] = temp;
    }

    public int Length()
    {
        return _taskList.Count();
    }

    public void DeleteSelected()
    {
        _taskList.Remove(_taskList[_cursorIndex]);
    }

    public Task GetTask(int index)
    {
        return _taskList[index];
    }
}