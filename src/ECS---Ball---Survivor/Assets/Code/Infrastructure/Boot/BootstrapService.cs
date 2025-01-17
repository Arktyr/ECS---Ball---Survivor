using Code.Infrastructure.StateMachine;
using Code.Infrastructure.StateMachine.States.GameStates;
using Zenject;

namespace Code.Infrastructure.Boot
{
    public class BootstrapService : IInitializable
    {
        private readonly IGameStateMachine _gameStateMachine;

        public BootstrapService(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        public void Initialize() => 
            _gameStateMachine.Enter<BootstrapState>();
    }
}