using EducationPlatform.application.Commands.CreatePaymentSignatureCommand;
using EducationPlatform.application.Commands.CreateSignatureCommand;
using EducationPlatform.application.Commands.CreateUserCommand;
using EducationPlatform.application.Commands.CreateUserSignatureCommand;
using EducationPlatform.application.Commands.DeleteUserCommand;
using EducationPlatform.application.Commands.UpdateSignatureCommand;
using EducationPlatform.application.Commands.UpdateUserCommand;
using EducationPlatform.application.Queries.GetAllUsers;
using EducationPlatform.application.Queries.GetUser;
using EducationPlatform.Core.Domain.Entities;
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
            if (!user.IsSuccess)
            {
                return BadRequest(user.Message);
            }
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
        [HttpPost]
        [Route("UserSignatures")]
        public async Task<IActionResult> CreateUserSignature([FromBody] CreateUserSignatureCommand command)
        {

            var userSignatureId=await _mediator
                .Send(command);

            return Ok(userSignatureId);

        }
        [HttpPost]
        [Route("UserSignatures/PaymentSignature")]
        public async Task<IActionResult> CreatePaymentSignature([FromBody] CreateSignaturePaymentCommand command)
        {
            var result=await _mediator
                .Send(command);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateUserCommand command) {

            command.Id= id;

            var result =await _mediator.Send(command);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return NoContent();
            
        }
        [HttpPut("{id}/UserSignature")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateUserSignatureCommand command)
        {

            command.Id = id;

            var result=await _mediator.Send(command);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return NoContent();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {

            var command = new DeleteUserCommand(id);

            var result=await _mediator.Send(command);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            //_userService.Delete(id);
            return Ok();

        }
    }
}
