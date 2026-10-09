namespace GameApp
{
    internal class GameFacade
    {
        GraphicsSystem graphics = new GraphicsSystem();
        AudioSystem audio = new AudioSystem();
        SaveSystem saveSystem = new SaveSystem();
        NetworkService network = new NetworkService();
        GameEngine gameEngine = new GameEngine();

        private bool isOnline;
        private GameBehavior gameBehavior;

        public GameFacade(GameBehavior gameBehavior, bool isOnline)
        {
            this.gameBehavior = gameBehavior;
            this.isOnline = isOnline;
        }

        public void StartGame()
        {
            Console.WriteLine("\n \n StartGame...");
            gameBehavior.Mode();

            graphics.Initialize();
            graphics.SetResolution(1920, 1080);

            audio.Initialize();
            audio.SetVolume(70);

            saveSystem.LoadSettings();
            saveSystem.LoadPlayer();

            if (isOnline)
            {
                network.Connect();
                network.Login();   
            }

            gameEngine.LoadWorld();
            gameEngine.Start();
        }

        public void StopGame()
        {
            Console.WriteLine("\n \n Shutdown...");
            graphics.Shutdown();
            audio.Shutdown();
            saveSystem.SavePlayer();
            saveSystem.SaveSettings();
            if (isOnline)
            {
                network.Logout();
                network.Disconnect();   
            }
            gameEngine.UnloadWorld();
            gameEngine.Stop();
        }

    }
}