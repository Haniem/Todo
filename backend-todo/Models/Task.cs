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

        public string? status { get; set; } 

        [ForeignKey("userId")]
        public int? userId { get; set; }
        public User? User { get; set; }
    }
}