/*****************
* Name: Caleb Roskelley
* Lab 4 Big ToDo List
* Professor Lewellan
*****************/
class Program {
    static void Main() {
        TodoList newToDoList = new TodoList();
        TodoListApp newToDoListApp = new TodoListApp(newToDoList);
        newToDoListApp.Run();
        //new ToDoListApp(new ToDoList()).Run();
        
    }
}
