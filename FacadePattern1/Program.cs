namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartStopGame startStopGame = new StartStopGame(new NormalMode());

            startStopGame.StartGame();

            startStopGame.StopGame();

            Console.ReadLine();
        }
    }
}