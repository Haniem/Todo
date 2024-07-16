using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_todo.Data;
using Microsoft.AspNetCore.Mvc;

namespace backend_todo.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {  
        private readonly ApplicationDBContext _context;

        public UserController(ApplicationDBContext context)
        {
            _context = context;
        }   

        [HttpGet]

        public IActionResult GetAll(){
            var users = _context.Users.ToList();

            return Ok(users);
        }

        [HttpGet("{id}")]

        public IActionResult getById([FromRoute] int id){
            var user = _context.Users.Find(id);

            if (user == null) {
                
                return NotFound();
            }

            return Ok(user);
        }   
    }
}