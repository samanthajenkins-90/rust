using System;

namespace App
{
    public class HybridFactory
    {
        private int _state;

        public HybridFactory(int seed) => _state = seed;

        public int parse(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 82) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new HybridFactory(82);
            Console.WriteLine(obj.parse(82));
        }
    }
}
