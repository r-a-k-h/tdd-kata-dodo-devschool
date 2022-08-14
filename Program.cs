using System;

namespace tdd_kata_dodo
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzCheck();
        }

        private static void FizzBuzzCheck()
        {
            var fizzBuzz = new FizzBuzzClass();
            for (var i = 1; i < 101; i++)
            {
                Console.WriteLine(fizzBuzz.FizzBuzz(i));
            }
        }
    }
}