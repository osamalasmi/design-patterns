using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Projector
    {
        private DvdPlayer _dvdPlayer;

        public Projector()
        {
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            Console.WriteLine("Projector setting input to DVD player");
            this._dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector in TV mode (4x3)");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector in widescreen mode (16x9)");
        }
    }
}