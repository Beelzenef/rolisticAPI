using System.Collections.Generic;
using RolisticAPI._Data;
using RolisticAPI._Entities;
using RolisticAPI._Repositories.Contracts;

namespace RolisticAPI._Repositories
{
    public class RulebookRepository : IRepository<Rulebook>
    {
        public Rulebook Find(int id)
        {
            var rulebook = MockData.RulebookData.Find(m => m.Id == id);
            return rulebook;
        }

        public List<Rulebook> GetAll()
        {
            var rulebookData = MockData.RulebookData.FindAll(m => true);
            return rulebookData;
        }
    }
}
