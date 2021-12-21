using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            //  Задание 1 - Вывести массив в обратном порядке
            int[] myArray = { 3, 100, 12, 9, 0 };

            for (int i = myArray.Length; i > 0; i--)
            {
                Console.WriteLine(myArray[i - 1]);
            }

            //Задание 2 - Заполнить массив из клавиатуры

            Console.WriteLine("Введите количество элементов массива: ");

            int elemets = int.Parse(Console.ReadLine());

            int[] myArray1 = new int[elemets];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Введите число в массив: ");
                myArray[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Массив:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }


            // Задание 3 - Сумма четных чисел

            int[] myArray2 = { 1, 4, 10, 5, 12, 3 };

            int evenNum = 0;

            int oddNum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evenNum += myArray[i];
                }
                else
                {
                    oddNum += myArray[i];
                }
            }

            Console.WriteLine("Сумма четных чисел = " + evenNum);
            Console.WriteLine("Сумма нечетных чисел = " + oddNum);


        }
    }
}
