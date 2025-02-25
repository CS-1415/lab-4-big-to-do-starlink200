using System.Runtime.InteropServices;

public class TodoList
{
    public List<Task> _taskList {get; set;}
    public int _cursorIndex {get; set;}

    public TodoList()
    {
        _taskList = new List<Task>();
    }
    public TodoList(List<Task> tasks, int cursorIndex)
    {
        _taskList = tasks;
        _cursorIndex = cursorIndex;
    }

    public void Insert(string title)
    {
        Task newTask = new Task(title, false);
        _taskList!.Add(newTask);
        
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
        if(_cursorIndex - 1 >= 0)
        {
        _taskList[_cursorIndex] = _taskList[_cursorIndex - 1];
        _taskList[_cursorIndex - 1] = temp;
        }
    }

    public void SwapWithNext()
    {
        Task temp = _taskList[_cursorIndex];
        if(_cursorIndex + 1 != _taskList.Count())
        {
            _taskList[_cursorIndex] = _taskList[_cursorIndex + 1];
            _taskList[_cursorIndex + 1] = temp;
        }
    }

    public int Length()
    {
        return _taskList.Count;
    }

    public void DeleteSelected()
    {
        if(_cursorIndex >= _taskList.Count() - 1)
        {
            _cursorIndex = _taskList.Count() - 1;
        }
        if(_cursorIndex < 0)
        {
            _cursorIndex = 0;
        }
        else
        {
            _taskList.Remove(_taskList[_cursorIndex]);
        }
    }

    public Task GetTask(int index)
    {
        return _taskList[index];
    }

    public Task CurrentTask()
    {
        return _taskList[_cursorIndex];
    }
}

