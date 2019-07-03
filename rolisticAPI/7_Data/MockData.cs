using System;
using System.Collections.Generic;
using RolisticAPI._Entities;

namespace RolisticAPI._Data
{
    public static class MockData
    {
        public static List<Rulebook> RulebookData = new List<Rulebook>
        {
            new Rulebook { Id = 1, Title = "Vampiro: La Mascarada", PublishYear = 1997, Stars = 5,CreateDate = DateTime.Now },
            new Rulebook { Id = 2, Title = "Dungeons & Dragons 5ed", PublishYear = 1984, Stars = 3, CreateDate = DateTime.Now },
            new Rulebook { Id = 3, Title = "13th Age", PublishYear = 2016, Stars = 8, CreateDate = DateTime.Now }
        };
    }
}
