public class ToDoList
{
    public List<Task> _taskList {get; set;}
    public int _cursorIndex {get; set;}

    public ToDoList()
    {

    }
    public ToDoList(List<Task> tasks, int cursorIndex)
    {
        _taskList = tasks;
        _cursorIndex = cursorIndex;
    }

    public void SwapTaskBefore()
    {
        Task temp = _taskList[_cursorIndex];
        _taskList[_cursorIndex] = _taskList[_cursorIndex - 1];
        _taskList[_cursorIndex - 1] = temp;
    }

    public void SwapTaskAfter()
    {
        Task temp = _taskList[_cursorIndex];
        _taskList[_cursorIndex] = _taskList[_cursorIndex + 1];
        _taskList[_cursorIndex + 1] = temp;
    }
}