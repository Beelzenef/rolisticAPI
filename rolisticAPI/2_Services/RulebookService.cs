using System.Collections.Generic;
using RolisticAPI._DTO;
using RolisticAPI._DTO.Mappers;
using RolisticAPI._Repositories;

namespace RolisticAPI._Services
{
    public class RulebookService : IRulebookService
    {
        RulebookRepository repository;

        public RulebookService()
        {
            repository = new RulebookRepository();
        }

        public List<RulebookDTO> GetAllRulebooks()
        {
            var allRulebooks = repository.GetAll();

            if (allRulebooks == null || allRulebooks.Count == 0)
            {
                return null;
            }

            var rulebooksDTOs = RulebookDTOMapper.Map(allRulebooks);
            return rulebooksDTOs;
        }

        public RulebookDTO GetRulebookById(int id)
        {
            var rulebookById = repository.Find(id);

            if (rulebookById == null)
            {
                return null;
            }

            var rulebookDTO = RulebookDTOMapper.Map(rulebookById);
            return rulebookDTO;
        }
    }
}
