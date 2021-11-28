using System;

namespace Zawodnicy.Core.Domain
{
    public class SkiJumper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public DateTime BornDate { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        
        public Trainer Trainer { get; set; }

        public bool Equals(SkiJumper other)
        {
            return Id == other.Id && 
                   Name == other.Name && 
                   Surname == other.Surname && 
                   Country == other.Country &&
                   BornDate.Equals(other.BornDate) && 
                   Height.Equals(other.Height) && 
                   Weight.Equals(other.Weight);
        }
    }
}