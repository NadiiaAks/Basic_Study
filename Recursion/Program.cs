using System;

namespace Recursion
{
    class Program
    {
        //Method for displaying array elements
        static void ArrayWrite(int[] arr, int Index)
        {

            Console.WriteLine(arr[Index]);

            if (Index >= arr.Length)
                return;

            Index++;
            ArrayWrite(arr, Index);
        }

        //Check ArrayWrite
        static void Main(string[] args)
        {
            int a = 0;
            int[] myArray = { 22, 1, 5, 78, 9, 145 };

            ArrayWrite(myArray, a);

        }
    }
}
