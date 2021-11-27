using System;
using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class City
    {
        public String CityName { get; set; }
        public long Id { get; set; }
        public List<SkiRamp> Ramps { get; set; }
    }
}