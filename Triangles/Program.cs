using System;

namespace Triangles
{
    class Program
    {
        //Displaying triangles to the console
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту: ");
            int hight = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write("#");
                }

                counter = counter + 1;

                Console.Write("\n");
            }

            Console.Write("\n");

            int counter2 = hight;

            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < counter2; j++)
                {
                    Console.Write("#");
                }

                counter2 = counter2 - 1;

                Console.Write("\n");
            }

            Console.Write("\n");

            int counter3 = 1;

            int probel = hight - 1;

            for (int i = 0; i < hight; i++)
            {
                for (int p = 0; p < probel; p++)
                {
                    Console.Write(" ");
                }

                probel = probel - 1;

                for (int j = 0; j < counter3; j++)
                {
                    Console.Write("#");
                }

                counter3 = counter3 + 1;

                Console.Write("\n");
            }

            Console.Write("\n");

            int counter4 = hight;

            int probel2 = 0;

            for (int i = 0; i < hight; i++)
            {
                for (int p = 0; p < probel2; p++)
                {
                    Console.Write(" ");
                }

                probel2 = probel2 + 1;

                for (int j = 0; j < counter4; j++)
                {
                    Console.Write("#");
                }

                counter4 = counter4 - 1;

                Console.Write("\n");
            }

            Console.Write("\n");

        }
    }
}
