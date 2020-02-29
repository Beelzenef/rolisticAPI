using System.Collections.Generic;
using System.Linq;
using rolisticAPI._Controllers.Filters;
using rolisticAPI._DTO;
using RolisticAPI._DTO;
using RolisticAPI._DTO.Mappers;
using RolisticAPI._Entities;
using RolisticAPI._Repositories;

namespace RolisticAPI._Services
{
    public class RulebookService : IRulebookService
    {
        readonly RulebookRepository repository;

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

        public List<RulebookStarsDTO> GetAllRulebooksWithStars()
        {
            var allRulebooks = repository.GetAll();

            if (allRulebooks == null || allRulebooks.Count == 0)
            {
                return null;
            }

            var rulebooksDTOs = RulebookDTOMapper.MapWithStars(allRulebooks);
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

        public List<RulebookDTO> GetRulebooksFiltered(RulebookFilter filter)
        {
            var elementsByPage = 3;

            var rulebooksFiltered = repository.FilterRulebooks(filter.Title,
                filter.Asc, filter.Year);

            if (rulebooksFiltered == null || rulebooksFiltered.Count == 0)
            {
                return null;
            }

            List<Rulebook> paginationResult;

            if (rulebooksFiltered.Count > elementsByPage)
            {
                paginationResult = rulebooksFiltered
                    .Skip(filter.Page * elementsByPage)
                    .Take(elementsByPage)
                    .ToList();
            }
            else
            {
                paginationResult = rulebooksFiltered;
            }

            var result = RulebookDTOMapper.Map(paginationResult);
            return result;
        }
    }
}
