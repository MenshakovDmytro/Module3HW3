using System;

namespace Module3HW3
{
    public class FirstClass
    {
        public Action<bool> Action { get; set; }

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
