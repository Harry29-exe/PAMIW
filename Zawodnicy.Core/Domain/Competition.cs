using System;
using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class Competition
    {
        private long Id { get; set; }
        private string Name { get; set; }
        private DateTime Date { get; set; }
        
        private SkiRamp Ramp { get; set; }
        private List<Participation> Participations { get; set; }
    }
}