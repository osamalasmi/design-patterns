namespace GameApp
{
    internal class StartStopGame
    {
        GraphicsSystem graphics = new GraphicsSystem();
        AudioSystem audio = new AudioSystem();
        SaveSystem saveSystem = new SaveSystem();
        NetworkService network = new NetworkService();
        GameEngine gameEngine = new GameEngine();
        private GameMode gameMode;

        public StartStopGame(GameBehavior gameBehavior)
        {
            gameMode = new GameMode(gameBehavior);
        }

        public void StartGame()
        {
            gameMode.Mode();

            graphics.Initialize();
            graphics.SetResolution(1920, 1080);

            audio.Initialize();
            audio.SetVolume(70);

            saveSystem.LoadSettings();
            saveSystem.LoadPlayer();

            network.Connect();
            network.Login();

            gameEngine.LoadWorld();
            gameEngine.Start();
        }

        public void StopGame()
        {
            Console.WriteLine("\n \nShutdown...");
            graphics.Shutdown();
            audio.Shutdown();
            saveSystem.SavePlayer();
            saveSystem.SaveSettings();
            network.Disconnect();
            network.Logout();
            gameEngine.UnloadWorld();
            gameEngine.Stop();
        }

    }
}