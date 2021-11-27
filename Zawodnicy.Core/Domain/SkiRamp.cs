using System;
using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class SkiRamp
    {
        public long Id { get; set; }
        public String Country { get; set; }
        public String Name { get; set; }
        public int KPoint { get; set; }
        public int JudgeNotes { get; set; }
        
        public City City { get; set; }
        public List<Competition> Compentitions { get; set; } 
    }
}