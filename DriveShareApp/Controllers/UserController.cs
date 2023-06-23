using DriveShareApp.Core.DTOs;
using DriveShareApp.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        [HttpPost("uploadfile")]
        public PassengerDTO UploadFile()
        {
            if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine("C:\\Users\\Dell\\StudioProjects\\DriveShare\\images", fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                PassengerDTO item = new PassengerDTO();
                item.Imagefile = fileName;
                return item;
            }
            return null;
        }
        [HttpPut("updatepass")]
        public void updatepass(UserDTO userDTO)
        {
            userService.updatepass(userDTO);
        }
    }
}
