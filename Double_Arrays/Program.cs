using System;

namespace Double_Arrays
{
    class Program
    {
        //Заполнение двумерного массива и выведение его для проверки
        static void Main(string[] args)
        {
            Console.WriteLine("В массиве будет столбцов:");

            int elX = int.Parse(Console.ReadLine());

            Console.WriteLine("В массиве будет строк:");

            int elY = int.Parse(Console.ReadLine());

            int[,] myArray = new int[elX, elY];

            for (int x = 0; x < elX; x++)
            {
                for (int i = 0; i < elY; i++)
                {
                    Console.WriteLine("Введите число в массив:");

                    myArray[x, i] = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("Переходим к следующей строке");
            }

            Console.WriteLine("ПРОВЕРКА:");

            for (int c = 0; c < elX; c++)
            {
                for (int v = 0; v < elY; v++)
                {
                    Console.Write(myArray[c, v] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

        }
    }
}
