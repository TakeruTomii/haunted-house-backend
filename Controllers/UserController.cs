using haunted_house_backend.Models;
using haunted_house_backend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace haunted_house_backend.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;
        UserController()
        {
            this.userService = new UserService();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public LoginUser GetUser(string id)
        {
            return this.userService.Getuser(id);
        }

        // POST api/users
        [HttpPost]
        public void CreateUser([FromBody] LoginUser user)
        {
            this.userService.CreateUser(user);
        }

        // PUT api/users
        [HttpPut]
        public void UpdateUser([FromBody] LoginUser user)
        {
            this.userService.UpdateUser(user);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void DeleteUser(string id)
        {
            this.userService.DeleteUser(id);
        }
    }
}
