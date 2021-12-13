using System;

namespace Module3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            var firstClass = new FirstClass() { Action = program.Show };
            var secondClass = new SecondClass();
            var result = secondClass.Calc(firstClass.Pow, 6, 7).Invoke(7);
            firstClass.Action.Invoke(result);
        }

        public void Show(bool result)
        {
            Console.WriteLine(result);
        }
    }
}
