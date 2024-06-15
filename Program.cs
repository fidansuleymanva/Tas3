//TASK3: Girişdə n natural ədədi verilir. Bu ədədin sağdan birinci rəqəmini tapmaq tələb olunur.
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a natural number:");
            int number = int.Parse(Console.ReadLine());

            int rightmostDigit = number % 10;
            Console.WriteLine("The rightmost digit is: " + rightmostDigit);
        }
    }
}

