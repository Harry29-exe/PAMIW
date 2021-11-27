using System;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Infrastructure.DTO
{
    public class SkiJumperDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public DateTime BornDate { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }


        public static SkiJumperDTO from(SkiJumper skiJumper)
        {
            return new SkiJumperDTO()
            {
                Id = skiJumper.Id,
                Name = skiJumper.Name,
                Surname = skiJumper.Surname,
                Country = skiJumper.Country,
                BornDate = skiJumper.BornDate,
                Height = skiJumper.Height,
                Weight = skiJumper.Weight
            };
        }
    }
}