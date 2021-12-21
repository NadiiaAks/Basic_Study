using System;

namespace Cycles
{
    class Program
    {
        //Draw rectangle using cycles
        static void Main(string[] args)
        {

            Console.Write("Введиете высоту прямоугольника: ");
            int hight = int.Parse(Console.ReadLine());

            Console.Write("Введиете ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("#");
                }

                Console.Write("\n");
            }

            Console.ReadLine();

        }
    }
}
