using System;

namespace App
{
    public class CoreClient
    {
        private int _state;

        public CoreClient(int seed) => _state = seed;

        public int collect(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 6) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new CoreClient(6);
            Console.WriteLine(obj.collect(6));
        }
    }
}
