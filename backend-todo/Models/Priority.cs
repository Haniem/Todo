using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_todo.Models
{
    public class Priority
    {
        public int id { get; set; }

        public string? name { get; set; }

        public string? level { get; set; }

        public List<Task_Priority> Task_Priority { get; set; } = new List<Task_Priority>();

        public DateTime created_at { get; set; } = DateTime.UtcNow;

        public DateTime updated_at { get; set; } = DateTime.UtcNow;
    }
}