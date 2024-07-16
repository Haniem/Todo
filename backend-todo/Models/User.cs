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
        public string? email { get; set; }
        public string? PasswordHash { get; set; }

        public List<Task> Task { get; set; } = new List<Task>();
    }
}