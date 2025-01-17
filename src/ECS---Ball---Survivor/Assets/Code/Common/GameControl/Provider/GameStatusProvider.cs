namespace Code.Common.GameControl.Provider
{
    public class GameStatusProvider : IGameStatusProvider
    {
        private GameStatus _gameStatus;

        public GameStatus GameStatus => _gameStatus;

        public void SetGameStatus(GameStatus gameStatus) => 
            _gameStatus = gameStatus;
    }
}