using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace backend_todo.Models
{
    public class User
    {

        [Key]
        public int id { get; set; }
        public string? username { get; set; }

        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? email { get; set; }

        public List<Task> Task { get; set; } = new List<Task>();

        public List<Comment> Comments { get; set;} = new List<Comment>();
        
        public DateTime created_at { get; set; } = DateTime.UtcNow;

        public DateTime updated_at { get; set; } = DateTime.UtcNow;
        public string? PasswordHash { get; set; }

    }
}