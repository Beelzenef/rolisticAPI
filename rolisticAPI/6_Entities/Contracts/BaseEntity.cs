using System;

namespace RolisticAPI._Entities.Contracts
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
