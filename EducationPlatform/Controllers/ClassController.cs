using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [ApiController]
    [Route("api/Classes")]
    public class ClassController : Controller
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var classes = _classService.Get();
            return Ok(classes);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var class1 = _classService.GetById(id);
            return Ok(class1);
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewClassInputModel model)
        {
            var classId = _classService.Create(model);
            return CreatedAtAction(nameof(GetById), new { id = classId }, model);
        }
    }
}
