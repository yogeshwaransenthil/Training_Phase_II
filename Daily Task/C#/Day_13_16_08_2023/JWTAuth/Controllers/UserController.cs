using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using JWTAuth.Service;
using JWTAuth.Models;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<User>>GetUserByUsername(string username)
        {
            try
            {
                var user = await _userService.GetUserByUsername(username);
                return Ok(user);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUserTable(User user)
        {
            try
            {
                return await _userService.AddUserTable(user);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(string username,User user)
        {
            try
            {
                return await _userService.UpdateUser(username,user);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<ActionResult<List<User>>> DeleteUser(string username)
        {
            try
            {

                var users = await _userService.DeleteUser(username);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
