using System.Collections.Generic;
using System.Linq;
using TodoApplikasjonenDelTo;




namespace TodoApplikasjonenDelTo

{
    public class TodoService
    {
        private List<TodoItem> _todos = new List<TodoItem>();

        public IEnumerable<TodoItem> Todos => _todos; 

        public void AddTodo(string title)
        {
            var todo = new TodoItem { Title = title, IsCompleted = false };
            _todos.Add(todo);
        }

        public void MarkAsComplete(TodoItem todo)
        {
            todo.IsCompleted = true;
        }

        public void RemoveTodoItem(TodoItem todo)
        {
            _todos.Remove(todo);
        }

        public List<TodoItem> GetCompletedTodos()
        {
            return _todos.Where(todo => todo.IsCompleted).ToList();
        }
    }






}