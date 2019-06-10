using System;
using System.Collections.Generic;
using RolisticAPI._Entities;

namespace RolisticAPI._Data
{
    public static class MockData
    {
        public static List<Rulebook> RulebookData = new List<Rulebook>
        {
            new Rulebook { Id = 1, Title = "Vampiro: La Mascarada", PublishYear = 1997, CreateDate = DateTime.Now },
            new Rulebook { Id = 2, Title = "Dungeons & Dragons 5ed", PublishYear = 1984, CreateDate = DateTime.Now },
            new Rulebook { Id = 3, Title = "13th Age", PublishYear = 2016, CreateDate = DateTime.Now }
        };
    }
}
