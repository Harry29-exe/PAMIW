using System;

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
        
    }
}