namespace Engine.Common
{
    using System;

    public static class RandomGenerator
    {
        private static readonly Random rand;

        static RandomGenerator()
        {
            rand = new Random();
        }

        public static int Return(int a, int b)
        {
            return rand.Next(a, b + 1);
        }
    }
}
