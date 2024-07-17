using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_todo.Models
{
    public class Comment
    {
        public int id { get; set; }

        [ForeignKey("task_id")]

        public int? task_id { get; set; }

        public Task Task { get; set; }
        
        [ForeignKey("user_id")]

        public int? user_id { get; set; }

        public User? User { get; set; }

        
        
        public DateTime created_at { get; set; } = DateTime.UtcNow;

        public DateTime updated_at { get; set; } = DateTime.UtcNow;
    }
}