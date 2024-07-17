using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend_todo.Models
{
    public class Task_Tag
    {   
        public int id { get; set; }

        [ForeignKey("task_id")]
        
        public int? task_id { get; set; }
        public Task? Task { get; set; }

        [ForeignKey("tag_id")]

        public int? tag_id { get; set; }

        public Tag? Tag { get; set; }

        public DateTime created_at { get; set; } = DateTime.UtcNow;

        public DateTime updated_at { get; set; } = DateTime.UtcNow;

    }
}