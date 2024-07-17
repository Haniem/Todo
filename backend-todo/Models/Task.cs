using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_todo.Models
{
    public class Task
    {
        public int id { get; set; }

        public string? discription { get; set; }

        [ForeignKey("user_id")]
        public int? user_id { get; set; }
        public User? User { get; set; }
        public List<Task_Tag> Task_Tag { get; set; } = new List<Task_Tag>();

        public List<Task_Priority> Task_Priority { get; set; } = new List<Task_Priority>();

        public List<Attachments> Attachments { get; set; } = new List<Attachments>();

        public List<Comment> Comments { get; set;} = new List<Comment>();

        public DateTime created_at { get; set; } = DateTime.UtcNow;

        public DateTime updated_at { get; set; } = DateTime.UtcNow;
    }
}