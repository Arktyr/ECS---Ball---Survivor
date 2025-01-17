namespace Code.Common.GameControl.Provider
{
    public interface IGameStatusProvider
    {
        GameStatus GameStatus { get; }
        void SetGameStatus(GameStatus gameStatus);
    }
}