using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using rolisticAPI._Controllers.Filters;
using rolisticAPI._DTO;
using RolisticAPI._DTO;
using RolisticAPI._Services;

namespace RolisticAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulebookController : ControllerBase
    {
        readonly IRulebookService service;

        public RulebookController()
        {
            service = new RulebookService();
        }

        [HttpGet]
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

        [HttpGet("stars")]
        public ActionResult<IEnumerable<RulebookStarsDTO>> GetWithStars()
        {
            var allRulebooks = service.GetAllRulebooksWithStars();

            if (allRulebooks == null || allRulebooks.Count == 0)
            {
                return NoContent();
            }

            return allRulebooks;
        }

        [HttpPut("rulebooksfiltered")]
        public ActionResult<IEnumerable<RulebookDTO>> GetRulebooksFiltered(RulebookFilter filter)
        {
            var allRulebooks = service.GetRulebooksFiltered(filter);

            if (allRulebooks == null || allRulebooks.Count == 0)
            {
                return NoContent();
            }

            return allRulebooks;
        }

        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
