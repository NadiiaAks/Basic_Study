using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = Console.ReadLine();

            uint x = uint.Parse(Console.ReadLine());

            Write(w, x);


            int[] myArray = { 11, 2, 4, 88, 9 };

            int my = int.Parse(Console.ReadLine());

            Searching(myArray, my);

        }

        static void Searching(int[] arr, int c)
        {
            bool no = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (c == arr[i])
                {
                    Console.WriteLine("Индекс:" + i);
                    no = false;
                    break;

                }
                else
                {
                    no = true;

                }
            }

            if (no == true)
            {
                Console.WriteLine("Такого числа нет");
            }
        }
        static void Write(string a, uint b)
        {
            for (int i = 0; i < b; i++)
            {
                Console.Write(a);
            }
        }
    }
}
