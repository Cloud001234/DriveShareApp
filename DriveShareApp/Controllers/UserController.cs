using DriveShareApp.Core.DTOs;
using DriveShareApp.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveShareApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        
        [HttpPost("createuser")]
        public void createUser(UserDTO userDTO)
        {
            userService.createUser(userDTO);
        }

        [HttpPut("updateuser")]
        public void updateUser(UserDTO userDTO)
        {
            userService.updateUser(userDTO);
        }

        [HttpDelete("deleteuser")]
        public void deleteUser(UserDTO userDTO)
        {
            userService.deleteUser(Convert.ToInt32(userDTO.Passengerid));
        }

        [HttpPost("login")]
        public IActionResult userLogin([FromBody] UserDTO userDTO)
        {
           var token =userService.userLogin(userDTO);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }
    }
}
