namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Normal mode - online =====");
            StartStopGame onlineGame = new StartStopGame(new NormalMode(), true);
            onlineGame.StartGame();
            onlineGame.StopGame();

            Console.WriteLine();
            Console.WriteLine("===== Normal mode - offline =====");
            StartStopGame offlineGame = new StartStopGame(new NormalMode(), false);
            offlineGame.StartGame();
            offlineGame.StopGame();

            Console.WriteLine();
            Console.WriteLine("===== Developer mode - offline =====");
            StartStopGame developerGame = new StartStopGame(new DeveloperMode(), false);
            developerGame.StartGame();
            developerGame.StopGame();

            Console.ReadLine();
        }
    }
}