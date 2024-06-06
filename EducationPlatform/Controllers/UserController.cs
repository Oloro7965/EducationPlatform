using EducationPlatform.application.Commands.CreateSignatureCommand;
using EducationPlatform.application.Commands.CreateUserCommand;
using EducationPlatform.application.Commands.CreateUserSignatureCommand;
using EducationPlatform.application.Commands.DeleteUserCommand;
using EducationPlatform.application.Commands.UpdateUserCommand;
using EducationPlatform.application.Queries.GetAllUsers;
using EducationPlatform.application.Queries.GetUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            //_userService = userService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            //var users= _userService.Get(query);
            var Query = new GetAllUsersQuery(query);

            var users = await _mediator.Send(Query);

            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {

            var query = new GetUserQuery(id);

            var user=await _mediator.Send(query);

            return Ok(user);
            //var user=_userService.GetById(id);
            //return Ok(user);

        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            //var userId=_userService.Create(model);
            var userId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new {id = userId}, command);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateUserCommand command) {

            command.Id= id;

            await _mediator.Send(command);

            return NoContent();
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {

            var command = new DeleteUserCommand(id);

            await _mediator.Send(command);

            //_userService.Delete(id);
            return Ok();

        }
    }
}
