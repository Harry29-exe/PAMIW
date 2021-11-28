using Zawodnicy.Core.Domain;

namespace UnitTests.Infrastructure
{
    public class Utils
    {
        /**
         * Id = 1,
         * Name = "Alan",
         * Surname = "G",
         * Country = "pol",
         * Weight = 170
         */
        public static SkiJumper CreateJumper1()
        {
            return new SkiJumper()
            {
                Id = 1,
                Name = "Alan",
                Surname = "G",
                Country = "pol",
                Weight = 170
            };
        }

        /**
         * Id = 2,
         * Name = "Adam",
         * Surname = "P",
         * Country = "ger",
         * Weight = 172
         */
        public static SkiJumper CreateJumper2()
        {
            return new SkiJumper()
            {
                Id = 2,
                Name = "Adam",
                Surname = "P",
                Country = "ger",
                Weight = 172
            };
        }

        /**
         * Id = 3,
         * Name = "Martin",
         * Surname = "S",
         * Country = "fin",
         * Weight = 172
         */
        public static SkiJumper CreateJumper3()
        {
            return new SkiJumper()
            {
                Id = 3,
                Name = "Martin",
                Surname = "S",
                Country = "fin",
                Weight = 172
            };
        }

    }
}