using System;

namespace App
{
    public class CoreController
    {
        private int _state;

        public CoreController(int seed) => _state = seed;

        public int parse(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 5) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new CoreController(5);
            Console.WriteLine(obj.parse(5));
        }
    }
}
