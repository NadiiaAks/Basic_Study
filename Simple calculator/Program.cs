using System;

namespace Simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вид операции");

            string c = Console.ReadLine();

            if (c == "+")
            {
                Console.WriteLine(a + b);
            }

            else if (c == "-")
            {
                Console.WriteLine(a - b);
            }

            else if (c == "*")
            {
                Console.WriteLine(a + b);
            }

            else if (c == "/")
            {
                Console.WriteLine(a / b);

                if (b == 0)

                    Console.WriteLine("Делить на 0 нельзя");

                else
                {
                    Console.WriteLine(a / b);
                }
            }

            else
            {
                Console.WriteLine("Неизвестный символ!");
            }
        }
    }
}
