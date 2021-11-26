using System;

namespace Zawodnicy.Core.Domain
{
    public class SkiJumper
    {
        private long Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Country { get; set; }
        private DateTime BornDate { get; set; }
        private float Height { get; set; }
        private float Weight { get; set; }
        
        private Trainer Trainer { get; set; } 
    }
}