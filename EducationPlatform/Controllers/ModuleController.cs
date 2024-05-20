using EducationPlatform.application.Commands.CreateModuleCommand;
using EducationPlatform.application.Commands.UpdateModuleCommand;
using EducationPlatform.application.Commands.UpdateUserCommand;
using EducationPlatform.application.Queries.GetAllModules;
using EducationPlatform.application.Queries.GetModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [Route("api/modules")]
    [ApiController]
    public class ModuleController : Controller
    {
        //private readonly IModuleService _moduleService;
        private readonly IMediator _mediator;

        public ModuleController(IMediator mediator)
        {

            //_moduleService = moduleService;
            _mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            //var users = _moduleService.Get();
            var query=new GetAllModulesQuery();

            var modules=await _mediator.Send(query);

            return Ok(modules);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {

            //var user = _moduleService.GetById(id);
            var query=new GetModuleQuery(id);

            var module = await _mediator.Send(query);

            return Ok(module);

        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateModuleCommand command)
        {

            //var moduleId = _moduleService.Create(model);
            var moduleId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = moduleId }, command);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateModuleCommand command)
        {

            command.Id = id;
            //_moduleService.Update(model);
            await _mediator.Send(command);

            return Ok(NoContent);

        }

    }

}
