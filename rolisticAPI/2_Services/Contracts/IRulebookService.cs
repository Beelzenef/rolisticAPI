using System.Collections.Generic;
using rolisticAPI._DTO;
using RolisticAPI._DTO;

namespace RolisticAPI._Services
{
    public interface IRulebookService
    {
        List<RulebookDTO> GetAllRulebooks();
        List<RulebookStarsDTO> GetAllRulebooksWithStars();
        RulebookDTO GetRulebookById(int id);
    }
}
