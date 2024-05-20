using EducationPlatform.application.Commands.CreateClassCommand;
using EducationPlatform.application.Queries.GetAllClasses;
using EducationPlatform.application.Queries.GetClass;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace EducationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/Classes")]
    public class ClassController : Controller
    {
        //private readonly IClassService _classService;
        private readonly IMediator _mediator;
        public ClassController(IMediator mediator)
        {
            //_classService = classService;
            _mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var classes = _classService.Get();
            var query = new GetAllClassesQuery();

            var classes = await _mediator.Send(query);

            return Ok(classes);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetClassQuery(id);

            var class1= await _mediator.Send(query);

            //var class1 = _classService.GetById(id);
            return Ok(class1);

        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClassCommand command)
        {
            //var classId = _classService.Create(model);
            var classId=await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = classId }, command);

        }
    }
}
