using System;

namespace PositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;

            Console.WriteLine("enter only number1");
            number1 = Convert.ToInt32(Console.ReadLine());

           if (number1 > -0)
            {
                Console.WriteLine("positive");
            }
           if(number1 < 0)
            {
                Console.WriteLine("negative");
            }
        }
    }
}
