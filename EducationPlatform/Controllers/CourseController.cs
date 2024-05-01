using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/Courses")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var users = _courseService.Get();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user = _courseService.GetById(id);
            return Ok(user);
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewCourseInputModel model)
        {
            var courseId = _courseService.Create(model);
            return CreatedAtAction(nameof(GetById), new { id = courseId }, model);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] CourseUpdateInputModel model)
        {
            _courseService.Update(model);
            return Ok(model);
        }
    }
}
