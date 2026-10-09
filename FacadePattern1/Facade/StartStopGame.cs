namespace GameApp
{
    internal class StartStopGame
    {
        GraphicsSystem graphics = new GraphicsSystem();
        AudioSystem audio = new AudioSystem();
        SaveSystem saveSystem = new SaveSystem();
        NetworkService network = new NetworkService();
        GameEngine gameEngine = new GameEngine();
        private bool isOnline;
        private GameMode gameMode;

        public StartStopGame(GameBehavior gameBehavior, bool isOnline)
        {
            gameMode = new GameMode(gameBehavior);
            this.isOnline = isOnline;
        }

        public void StartGame()
        {
            Console.WriteLine("\n \n StartGame...");
            gameMode.Mode();

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