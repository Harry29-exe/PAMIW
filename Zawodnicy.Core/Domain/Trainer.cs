using System;
using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class Trainer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        
        public List<SkiJumper> Pupils { get; set; }
    }
}