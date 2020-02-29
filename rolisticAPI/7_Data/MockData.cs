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
            new Rulebook { Id = 3, Title = "13th Age", PublishYear = 2016, Stars = 8, CreateDate = DateTime.Now },
            new Rulebook { Id = 4, Title = "sLAng", PublishYear = 2002, Stars = 3, CreateDate = DateTime.Now },
            new Rulebook { Id = 5, Title = "SCROLL", PublishYear = 2019, Stars = 5, CreateDate = DateTime.Now },
            new Rulebook { Id = 6, Title = "Demonio: La Caída", PublishYear = 1999, Stars = 3, CreateDate = DateTime.Now },
            new Rulebook { Id = 7, Title = "Ratas en las paredes", PublishYear = 2018, Stars = 5, CreateDate = DateTime.Now },
            new Rulebook { Id = 8, Title = "EXO 3463", PublishYear = 1995, Stars = 3, CreateDate = DateTime.Now },
            new Rulebook { Id = 9, Title = "Engel", PublishYear = 1984, Stars = 2, CreateDate = DateTime.Now },
            new Rulebook { Id = 10, Title = "Los secretos del mundo mágico", PublishYear = 2020, Stars = 4, CreateDate = DateTime.Now }
        };
    }
}
