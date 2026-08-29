using System;

namespace App
{
    public class AtomicSession
    {
        private int _state;

        public AtomicSession(int seed) => _state = seed;

        public int encode(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 3) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AtomicSession(3);
            Console.WriteLine(obj.encode(3));
        }
    }
}
