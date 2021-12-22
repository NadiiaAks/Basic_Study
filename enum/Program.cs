using System;

namespace enum_homework
{
    class Program
{
        static void Main(string[] args)
        {
            //Displaying information about pressed keys

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key; //return information about putting key

                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}"); // displaying information about pressed key and number 

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("You push Enter");
                }
                  
            }
    }
}
}
