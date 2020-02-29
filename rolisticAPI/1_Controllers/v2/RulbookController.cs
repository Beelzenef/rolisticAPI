using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using rolisticAPI._Controllers.Filters;
using rolisticAPI._DTO;
using RolisticAPI._DTO;
using RolisticAPI._Services;

namespace RolisticAPI.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v2/[controller]")]
    [ApiController]
    public class RulebookController : ControllerBase
    {
        readonly IRulebookService service;

        public RulebookController()
        {
            service = new RulebookService();
        }

        [HttpGet("stars"), MapToApiVersion("2.0")]
        public ActionResult<IEnumerable<RulebookStarsDTO>> GetWithStars()
        {
            var allRulebooks = service.GetAllRulebooksWithStars();

            if (allRulebooks == null || allRulebooks.Count == 0)
            {
                return NoContent();
            }

            return allRulebooks;
        }

        [HttpPut("rulebooksfiltered"), MapToApiVersion("2.0")]
        public ActionResult<IEnumerable<RulebookDTO>> GetRulebooksFiltered(RulebookFilter filter)
        {
            var allRulebooks = service.GetRulebooksFiltered(filter);

            if (allRulebooks == null || allRulebooks.Count == 0)
            {
                return NoContent();
            }

            return allRulebooks;
        }
    }
}
