using System;

namespace enum_homework
{
    class Program
{
        /*static void Main(string[] args)
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
        }*/

        enum dayOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thurthday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            dayOfWeek myDay = dayOfWeek.Friday;

            Console.WriteLine(myDay);

            Console.WriteLine((int)myDay); //number of day

            Console.WriteLine((dayOfWeek)4); //day of week

            dayOfWeek nextDay = GetNextDay(myDay);

            Console.WriteLine(nextDay); //displaying next day

        }

        // Method for displaying next day
        static dayOfWeek GetNextDay (dayOfWeek day)
        {
            if (day < dayOfWeek.Sunday)
                return day + 1;

            return dayOfWeek.Monday;
        }




    }
}
