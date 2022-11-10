using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0 && number % 3 == 0)
                Console.WriteLine("Число является четным и не оканчивается на цифру 3.");
            else if (number % 2 == 0)
                Console.WriteLine("Число является четным.");
            else if (number % 3 == 0)
                Console.WriteLine("Число оканчивается на цифру 3.");
            else
                Console.WriteLine("Число не является четным и не оканчивается на цифру 3.");

            Console.ReadKey();
        }
    }
}