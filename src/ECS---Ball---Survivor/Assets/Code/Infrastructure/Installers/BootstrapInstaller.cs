using Code.Infrastructure.Boot;
using Zenject;

namespace Code.Infrastructure.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindEntryPoint();
        }

        private void BindEntryPoint() => 
            Container.BindInterfacesAndSelfTo<BootstrapService>().AsSingle();
    }
}