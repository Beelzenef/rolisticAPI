using RolisticAPI._Entities.Contracts;

namespace RolisticAPI._Entities
{
    public class Rulebook : BaseEntity
    {
        public string Title { get; set; }
        public int PublishYear { get; set; }
    }
}
