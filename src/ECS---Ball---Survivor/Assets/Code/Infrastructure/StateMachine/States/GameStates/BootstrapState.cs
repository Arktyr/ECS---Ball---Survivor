using Code.Common.GameControl;
using Code.Infrastructure.StateMachine.States.StateInfrastructure;

namespace Code.Infrastructure.StateMachine.States.GameStates
{
    public class BootstrapState : SimpleState
    {
        private readonly IGameControlService _gameControlService;
        private readonly IGameStateMachine _gameStateMachine;

        public BootstrapState(IGameControlService gameControlService,
            IGameStateMachine gameStateMachine)
        {
            _gameControlService = gameControlService;
            _gameStateMachine = gameStateMachine;
        }

        public override void Enter()
        {
            InitializeServices();
            _gameControlService.StartGame();
        }

        public void InitializeServices()
        {
            _gameControlService.Initialize();
        }
    }
}