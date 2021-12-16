using System;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Infrastructure.DTO
{
    public class TrainerDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }

        public static TrainerDTO from(Trainer t)
        {
            return new TrainerDTO()
            {
                Id = t.Id,
                Name = t.Name,
                Surname = t.Surname,
                BirthDay = t.Birthday
            };
        }
        
    }
}