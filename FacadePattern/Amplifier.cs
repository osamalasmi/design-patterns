using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Amplifier
    {
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void SetCd(CdPlayer cdPlayer)
        {
            Console.WriteLine("Amplifier setting CD player");
            this._cdPlayer = cdPlayer;
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            Console.WriteLine("Amplifier setting DVD player");
            this._dvdPlayer = dvdPlayer;
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier stereo mode on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier surround sound on");
        }

        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine("Amplifier setting tuner");
            this._tuner = tuner;
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Amplifier setting volume to {volume}");
        }
    }
}