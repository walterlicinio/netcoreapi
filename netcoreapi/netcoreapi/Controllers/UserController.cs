using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using netcoreapi.Models;
using netcoreapi.Services;

namespace netcoreapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
   
        private readonly ILogger<UserController> _logger;
        private IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public String Get()
        {
            return "Testing";
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null) return BadRequest();
            return Ok(_userService.Create(user));

        }

       
    }
}
