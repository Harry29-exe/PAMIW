using System;
using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class SkiRamp
    {
        private long Id { get; set; }
        private String Country { get; set; }
        private String Name { get; set; }
        private int KPoint { get; set; }
        private int JudgeNotes { get; set; }
        
        private City City { get; set; }
        private List<Competition> Compentitions { get; set; } 
    }
}