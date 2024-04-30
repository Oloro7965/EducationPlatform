using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [Route("api/signatures")]
    [ApiController]
    public class SignatureController : Controller
    {
        private readonly ISignatureService _signatureService;

        public SignatureController(ISignatureService signatureService)
        {
            _signatureService = signatureService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _signatureService.Get();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var signature = _signatureService.GetById(id);
            return Ok(signature);
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewSignatureInputModel model)
        {
            var signatureId = _signatureService.Create(model);
            return CreatedAtAction(nameof(GetById), new { id = signatureId }, model);
        }
    }
}
