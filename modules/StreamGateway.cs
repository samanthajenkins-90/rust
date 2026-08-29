using System;

namespace App
{
    public class AtomicManager
    {
        private int _state;

        public AtomicManager(int seed) => _state = seed;

        public int collect(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 33) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AtomicManager(33);
            Console.WriteLine(obj.collect(33));
        }
    }
}
