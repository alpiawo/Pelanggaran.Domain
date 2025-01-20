using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            var user = _userService.GetAllUser();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            var created = _userService.CreateUser(user);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, User user)
        {
            var updated = _userService.UpdateUser(id, user);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _userService.GetUserById(id);
            if (existing == null) return NotFound();
            _userService.DeleteUser(id);
            return Ok("User berhasil dihapus.");
        }
    }
}
