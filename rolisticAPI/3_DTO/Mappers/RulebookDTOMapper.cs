using System.Collections.Generic;
using RolisticAPI._Entities;

namespace RolisticAPI._DTO.Mappers
{
    public static class RulebookDTOMapper
    {
        public static List<RulebookDTO> Map(List<Rulebook> rulebooks)
        {
            List<RulebookDTO> rulebookDTOs = new List<RulebookDTO>();

            foreach (var ruleb in rulebooks)
            {
                rulebookDTOs.Add(new RulebookDTO
                {
                    Id = ruleb.Id,
                    Title = ruleb.Title,
                    PublishYear = ruleb.PublishYear
                });
            }

            return rulebookDTOs;
        }

        public static RulebookDTO Map(Rulebook rulebook)
        {
            var rulebookDTO = new RulebookDTO
            {
                Id = rulebook.Id,
                Title = rulebook.Title,
                PublishYear = rulebook.PublishYear
            };

            return rulebookDTO;
        }
    }
}
