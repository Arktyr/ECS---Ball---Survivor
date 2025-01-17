using Code.Infrastructure.StateMachine.States.StateInfrastructure;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.StateMachine.States.Factory
{
  public interface IStateFactory
  {
    UniTask<T> GetState<T>() where T : class, IExitableState;
  }
}