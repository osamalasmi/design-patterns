namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Normal mode - online =====");
            GameFacade onlineGame = new GameFacade(new NormalMode(), true);
            onlineGame.StartGame();
            onlineGame.StopGame();

            Console.WriteLine();
            Console.WriteLine("===== Normal mode - offline =====");
            GameFacade offlineGame = new GameFacade(new NormalMode(), false);
            offlineGame.StartGame();
            offlineGame.StopGame();

            Console.WriteLine();
            Console.WriteLine("===== Developer mode - offline =====");
            GameFacade developerGame = new GameFacade(new DeveloperMode(), false);
            developerGame.StartGame();
            developerGame.StopGame();

            Console.ReadLine();
        }
    }
}