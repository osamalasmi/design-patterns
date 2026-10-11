namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights theaterLights = new TheaterLights();
            Tuner tuner = new Tuner(amp);


            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(
                amp, cdPlayer, dvdPlayer, popcornPopper, projector, screen, theaterLights, tuner);
                
            homeTheaterFacade.WatchMovie("Inception");
            homeTheaterFacade.EndMovie();
        }
    }
}