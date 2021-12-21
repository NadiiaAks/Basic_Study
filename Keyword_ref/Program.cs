using System;

namespace Keyword_ref
{
    class Program
    {  // Метод для изменения величины массива - задание 1
        static void Resize(ref int[] arr, ref int NewSize)
        {
            int[] New = new int[NewSize];

            for (int i = 0; i < arr.Length && i < NewSize; i++)
            {
                New[i] = arr[i];
            }

            arr = New;

        }



        static void Main(string[] args)
        {
            // Задание 1 - изменить величину массива
            int[] myArray = { 6, 33, 4, 234, 8, 90, 1 };

            int c = 12;

            Resize(ref myArray, ref c);

            Console.ReadLine();

        }
    }
}
