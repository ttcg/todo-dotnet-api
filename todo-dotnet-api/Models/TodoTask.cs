using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_dotnet_api.Models
{
    public class TodoTask
    {
        public Guid Id { get; set; }
        public string TaskItem { get; set; }
        public bool HasDone { get; set; }
        public DateTime? DoneBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
