using Code.Common.GameControl;
using Code.Common.GameControl.Provider;
using Code.Common.MonoHelper;
using Code.Common.Time;
using Code.Infrastructure.StateMachine;
using Code.Infrastructure.StateMachine.States.Factory;
using Code.Infrastructure.StateMachine.States.GameStates;
using Zenject;

namespace Code.Infrastructure.Installers
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindStateMachine();
            BindStates();
            BindCommonServices();
        }

        private void BindStateMachine()
        {
            Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
            Container.BindInterfacesAndSelfTo<StateFactory>().AsSingle();
        }

        private void BindStates()
        {
            Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
        }

        private void BindCommonServices()
        {
            Container.BindInterfacesAndSelfTo<TimeService>().AsSingle();
            Container.Bind<IGameStatusProvider>().To<GameStatusProvider>().AsSingle();
            Container.Bind<MonoBehaviourApplicationHelper>().FromNewComponentOnNewGameObject().AsSingle();
            Container.BindInterfacesAndSelfTo<GameControlService>().AsSingle();
        }
    }
}