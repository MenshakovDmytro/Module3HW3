using System;

namespace Module3HW3
{
    public class SecondClass
    {
        private int _result;

        public Func<int, bool> Calc(Func<int, int, int> func, int x, int y)
        {
            _result = func.Invoke(x, y);
            return Result;
        }

        public bool Result(int x)
        {
            var num = _result % x;
            return num % 2 == 0;
        }
    }
}
