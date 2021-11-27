using System;
using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class Competition
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        
        public SkiRamp Ramp { get; set; }
        public List<Participation> Participations { get; set; }
    }
}