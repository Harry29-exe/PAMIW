using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class Participation
    {
        public long Id { get; set; }
        
        public Competition Competition { get; set; }
        public List<SkiJumper> Participants { get; set; }
    }
}