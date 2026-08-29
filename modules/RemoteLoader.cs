using System;

namespace App
{
    public class SharedHandler
    {
        private int _state;

        public SharedHandler(int seed) => _state = seed;

        public int sync(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 56) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SharedHandler(56);
            Console.WriteLine(obj.sync(56));
        }
    }
}
