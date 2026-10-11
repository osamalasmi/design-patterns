using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier amp;
        private CdPlayer cdPlayer;
        private DvdPlayer dvdPlayer;
        private PopcornPopper popcornPopper;
        private Projector projector;
        private Screen screen;
        private TheaterLights theaterLights;
        private Tuner tuner;

        public HomeTheaterFacade(
            Amplifier amp,
            CdPlayer cdPlayer,
            DvdPlayer dvdPlayer,
            PopcornPopper popcornPopper,
            Projector projector,
            Screen screen,
            TheaterLights theaterLights,
            Tuner tuner)
        {
            this.amp = amp;
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.popcornPopper = popcornPopper;
            this.projector = projector;
            this.screen = screen;
            this.theaterLights = theaterLights;
            this.tuner = tuner;
        }


        public void WatchMovie(string movieName)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popcornPopper.On();
            popcornPopper.Pop();

            theaterLights.Dim(10);

            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amp.On();
            amp.SetDvd(dvdPlayer);
            amp.SetSurroundSound();
            amp.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play(movieName);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();
            popcornPopper.Off();
            theaterLights.On();
            screen.Up();
            projector.Off();
            amp.Off();
        }
    }
}
