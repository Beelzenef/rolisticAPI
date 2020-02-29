using System.Collections.Generic;
using System.Linq;
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

        public List<Rulebook> FilterRulebooks(string title, bool asc, int year)
        {
            var query = MockData.RulebookData.Select(r => r);

            // Content filters
            if (!string.IsNullOrEmpty(title))
            {
                query = query.Where(r => r.Title.ToUpper()
                    .Contains(title.ToUpper()));  
            }
            if (year != 0)
            {
                query = query.Where(r => r.PublishYear == year);
            }

            // Ascending or descending
            if (asc)
            {
                query = query.OrderBy(r => r.Id);
            }
            else
            {
                query = query.OrderByDescending(r => r.Id);
            }

            var result = query.ToList();
            return result;
        }
    }
}
