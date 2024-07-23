using EducationPlatform.application.Commands.CreateClassCommand;
using EducationPlatform.application.Commands.CreateCourseCommand;
using EducationPlatform.application.Commands.UpdateCourseCommand;
using EducationPlatform.application.Queries.GetAllCourses;
using EducationPlatform.application.Queries.GetCourse;
using EducationPlatform.Core.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/Courses")]
    public class CourseController : Controller
    {
        //private readonly ICourseService _courseService;
        private readonly IMediator _mediator;
        public CourseController(IMediator mediator)
        {

            //_courseService = courseService;
            _mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            //var users = _courseService.Get();

            var Query = new GetAllCoursesQuery();

            var Courses = await _mediator.Send(Query);

            return Ok(Courses);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            //var user = _courseService.GetById(id);

            var query = new GetCourseQuery(id);

            var course=await _mediator.Send(query);
            if (!course.IsSuccess)
            {
                return BadRequest(course.Message);
            }
            return Ok(course);

        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCourseCommand command)
        {
            //var courseId = _courseService.Create(model);
            var courseId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = courseId }, command);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id,[FromBody] UpdateCourseCommand command)
        {
            //_courseService.Update(model);
            command.Id = id;

            var result=await _mediator.Send(command);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return Ok(NoContent);

        }
    }
}
