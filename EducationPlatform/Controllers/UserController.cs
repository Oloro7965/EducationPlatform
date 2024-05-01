using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var users= _userService.Get(query);
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user=_userService.GetById(id);
            return Ok(user);
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewUserInputModel model)
        {
            var userId=_userService.Create(model);
            return CreatedAtAction(nameof(GetById), new {id=userId},model);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] UserUpdateInputModel model) {
            _userService.Update(model);
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}
