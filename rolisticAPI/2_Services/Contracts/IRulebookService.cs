using System.Collections.Generic;
using RolisticAPI._DTO;

namespace RolisticAPI._Services
{
    public interface IRulebookService
    {
        List<RulebookDTO> GetAllRulebooks();
        RulebookDTO GetRulebookById(int id);
    }
}
