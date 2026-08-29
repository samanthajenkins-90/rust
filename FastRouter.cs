using System;

namespace App
{
    public class CoreContext
    {
        private int _state;

        public CoreContext(int seed) => _state = seed;

        public int fetch(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 8) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new CoreContext(8);
            Console.WriteLine(obj.fetch(8));
        }
    }
}
