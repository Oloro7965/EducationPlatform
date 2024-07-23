using EducationPlatform.application.Commands.CreateSignatureCommand;
using EducationPlatform.application.Queries.GetAllSignatures;
using EducationPlatform.application.Queries.GetSignature;
using EducationPlatform.Core.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationPlatform.API.Controllers
{
    [Route("api/signatures")]
    [ApiController]
    public class SignatureController : Controller
    {
        //private readonly ISignatureService _signatureService;
        private readonly IMediator _mediator;
        public SignatureController(IMediator mediator)
        {
            //_signatureService = signatureService;
            _mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var query = new GetAllSignaturesQuery();

            var signatures=await _mediator.Send(query);

            return Ok(signatures);
            //var users = _signatureService.Get();
            //return Ok(users);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {

            var Query=new GetSignatureQuery(id);

            var signature = await _mediator.Send(Query);

            if (!signature.IsSuccess)
            {
                return BadRequest(signature.Message);
            }

            return Ok(signature);
            //var signature = _signatureService.GetById(id);
            //return Ok(signature);

        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSignatureCommand command)
        {

            var signatureid=await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = signatureid }, command);
            //var signatureId = _signatureService.Create(model);
            //return CreatedAtAction(nameof(GetById), new { id = signatureid }, command);

        }
    }
}
