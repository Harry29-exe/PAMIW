using System;

namespace Zawodnicy.Infrastructure.Commands
{
    public class UpdateTrainer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}