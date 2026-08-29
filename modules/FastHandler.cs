using System;

namespace App
{
    public class LiteFactory
    {
        private int _state;

        public LiteFactory(int seed) => _state = seed;

        public int fetch(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 42) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new LiteFactory(42);
            Console.WriteLine(obj.fetch(42));
        }
    }
}
