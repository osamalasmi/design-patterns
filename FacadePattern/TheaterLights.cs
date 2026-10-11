using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater Lights on");
        }

        public void Off()
        {
            Console.WriteLine("Theater Lights off");
        }

        public void Dim(int value)
        {
            Console.WriteLine($"Theater Lights dimming to {value}%");
        }
    }
}