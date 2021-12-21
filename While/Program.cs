using System;

namespace While
{
    class Program
    {
        //Counting even and odd numbers
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;

            uint evenNumbersCount = 0;

            int currentValue = 1;

            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)

            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                }
                else
                {
                    oddNumbersCount++;
                }
                currentValue++;
            }

            Console.WriteLine("Нечетных чисел " + oddNumbersCount);

            Console.WriteLine("четных чисел" + evenNumbersCount);
            Console.ReadLine();
        }
    }
}
