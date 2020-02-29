using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RolisticAPI._DTO;
using RolisticAPI._Services;

namespace RolisticAPI.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RulebookController : ControllerBase
    {
        readonly IRulebookService service;

        public RulebookController()
        {
            service = new RulebookService();
        }

        [HttpGet, MapToApiVersion("1.0")]
        public ActionResult<IEnumerable<RulebookDTO>> Get()
        {
            var allRulebooks = service.GetAllRulebooks();

            if (allRulebooks == null || allRulebooks.Count == 0)
            {
                return NoContent();
            }

            return allRulebooks;
        }

        [HttpGet("{id}")]
        public ActionResult<RulebookDTO> Get(int id)
        {
            var rulebook = service.GetRulebookById(id);

            if (rulebook == null)
            {
                return NoContent();
            }

            return rulebook;
        }
    }
}
