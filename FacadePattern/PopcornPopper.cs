using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn Popper on");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn Popper off");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn Popper popping popcorn!");
        }
    }
}