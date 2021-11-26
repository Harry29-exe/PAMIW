using System;
using System.Collections.Generic;

namespace Zawodnicy.Core.Domain
{
    public class City
    {
        private String CityName { get; set; }
        private long Id { get; set; }
        private List<SkiRamp> Ramps { get; set; }
    }
}