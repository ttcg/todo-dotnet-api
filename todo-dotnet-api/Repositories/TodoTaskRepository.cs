using System;
using System.Collections.Generic;
using System.Linq;
using todo_dotnet_api.Models;

namespace todo_dotnet_api.Repositories
{
    public class TodoTaskRepository
    {
        private static List<TodoTask> _TodoTasks;

        public TodoTaskRepository()
        {
            if (_TodoTasks == null || _TodoTasks.Any() == false)
                Seed();
        }

        private void Seed()
        {
            _TodoTasks =
                new List<TodoTask>()
                {
                    new TodoTask() {Id = Guid.NewGuid(), TaskItem = "Learn React", DoneBy = DateTime.Now.Date.AddMonths(2)},
                    new TodoTask() {Id = Guid.NewGuid(), TaskItem = "Learn React-Router", DoneBy = DateTime.Now.Date.AddDays(-1)},
                    new TodoTask() {Id = Guid.NewGuid(), TaskItem = "Learn Redux", DoneBy = DateTime.Now.Date.AddMonths(3)},
                    new TodoTask() {Id = Guid.NewGuid(), TaskItem = "Learn Axios", HasDone = true, DoneBy = DateTime.Now.Date.AddDays(-7)},
                    new TodoTask() {Id = Guid.NewGuid(), TaskItem = "Create a sample app", HasDone = true},
                    new TodoTask() {Id = Guid.NewGuid(), TaskItem = "Deploy to Netlify", HasDone = true},
                    new TodoTask() {Id = Guid.NewGuid(), TaskItem = "Learn HoC", DoneBy = DateTime.Now.Date.AddMonths(2)},
                    new TodoTask() {Id = Guid.NewGuid(), TaskItem = "Learn Jest", DoneBy = DateTime.Now.Date.AddMonths(2)},
                };
        }

        public void Reset() => Seed();

        public IList<TodoTask> Get() => _TodoTasks;

        public void Add(TodoTask item) => _TodoTasks.Add(item);

        public TodoTask GetById(Guid id) => _TodoTasks.SingleOrDefault(item => item.Id == id);

        public void Update(TodoTask item)
        {
            var index = _TodoTasks.FindIndex(p => p.Id.Equals(item.Id));
            if (index != -1)
                _TodoTasks[index] = item;
        }

        public void Delete(Guid id) => _TodoTasks.RemoveAll(item => item.Id == id);

    }
}
