using System;

namespace App
{
    public class SecureGateway
    {
        private int _state;

        public SecureGateway(int seed) => _state = seed;

        public int sync(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 36) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SecureGateway(36);
            Console.WriteLine(obj.sync(36));
        }
    }
}
