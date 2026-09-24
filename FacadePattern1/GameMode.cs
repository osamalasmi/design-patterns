namespace GameApp
{
    internal class GameMode : GameBehavior
    {
        private GameBehavior gameBehavior = null!;

        public GameMode(GameBehavior gameBehavior)
        {
            this.gameBehavior = gameBehavior;
        }

        public void Mode()
        {
            gameBehavior.Mode();
        }

    }
}