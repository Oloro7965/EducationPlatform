using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [Route("api/modules")]
    [ApiController]
    public class ModuleController : Controller
    {
        private readonly IModuleService _moduleService;

        public ModuleController(IModuleService moduleService)
        {
            _moduleService = moduleService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var users = _moduleService.Get();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user = _moduleService.GetById(id);
            return Ok(user);
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewModuleInputModel model)
        {
            var moduleId = _moduleService.Create(model);
            return CreatedAtAction(nameof(GetById), new { id = moduleId }, model);
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] ModuleUpdateInputModel model)
        {
            _moduleService.Update(model);
            return Ok(model);
        }
    }
}
