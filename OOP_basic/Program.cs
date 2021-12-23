using System;

namespace OOP_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car's behavior:");
            var car = new Car();
            car.Driving();
            car.PrintSpeed();
            car.Stop();
            car.PrintSpeed();
            car.GoBack();
            car.PrintSpeed();

        }
    }
}
