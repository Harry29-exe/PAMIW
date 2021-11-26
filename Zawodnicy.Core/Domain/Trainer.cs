using System;
using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class Trainer
    {
        private long Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private DateTime Birthday { get; set; }
        
        private List<SkiJumper> Pupils { get; set; }
    }
}