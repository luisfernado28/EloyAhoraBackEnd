using Microsoft.AspNetCore.Mvc;
using EloyAhora.BLL;
using System.Threading.Tasks;
using EloyAhora.DAL.Models;
using Microsoft.AspNet.OData;

namespace EloyAhora.Api.Controllers
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

        [HttpPost]
        public async Task<IActionResult> PostUser(User user)
        {
            return await _userService.PostUser(user);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(string id)
        {
            _userService.DeleteUser(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] User user)
        {
            return await _userService.UpdateUser(user, id);
        }

        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> GetProducts()
        {
            return await _userService.GetUser();
        }


    }
}
