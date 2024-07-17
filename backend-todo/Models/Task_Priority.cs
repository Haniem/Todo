using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_todo.Models
{
    public class Task_Priority
    {
        public int id { get; set; }

        [ForeignKey("task_id")]
        public int? taks_id { get; set; }

        public Task? Task { get; set; }
        
        public DateTime created_at { get; set; } = DateTime.UtcNow;

        public DateTime updated_at { get; set; } = DateTime.UtcNow;
    }
}