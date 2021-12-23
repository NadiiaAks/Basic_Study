using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_basic
{
    class Car
    {
        private int speed = 0;

       // method for displaying speed on consol
       public void PrintSpeed()
       {
            if (speed == 0)
            {
                Console.WriteLine("The car doesn't go");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Driving with speed {speed}");
            }
            if (speed < 0)
            {
                Console.WriteLine($"Go back with speed {-speed}");
            }

            
       }

        // method for start driving
        public void Driving()
        {
            speed = 40;
        }

        // method for stop car
        public void Stop()
        {
            speed = 0;
        }

        // method for driving back
        public void GoBack()
        {
            speed = -10;
        }
    }
}
