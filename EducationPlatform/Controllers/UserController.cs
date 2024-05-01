using EducationPlatform.application.Commands.CreateUserCommand;
using EducationPlatform.application.Commands.DeleteUserCommand;
using EducationPlatform.application.Commands.UpdateUserCommand;
using EducationPlatform.application.InputModel;
using EducationPlatform.application.Queries.GetAllUsers;
using EducationPlatform.application.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMediator _mediator;
        public UserController(IUserService userService,IMediator mediator)
        {
            _userService = userService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            //var users= _userService.Get(query);
            var Query = new GetAllUsersQuery(query);
            var users=await _mediator.Send(Query);
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user=_userService.GetById(id);
            return Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            //var userId=_userService.Create(model);
            var userId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new {id=userId},command);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateUserCommand command) {
            await _mediator.Send(command);
            return Ok(NoContent);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command=new DeleteUserCommand(id);
            await _mediator.Send(command);
            //_userService.Delete(id);
            return Ok();
        }
    }
}
