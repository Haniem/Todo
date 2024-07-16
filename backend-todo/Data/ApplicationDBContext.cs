using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_todo.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_todo.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {
            
        }

        public virtual DbSet<Models.Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}