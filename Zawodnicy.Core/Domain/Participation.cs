using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class Participation
    {
        private long Id { get; set; }
        
        private Competition Competition { get; set; }
        private List<SkiJumper> Participants { get; set; }
    }
}