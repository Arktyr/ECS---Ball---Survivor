using Code.Infrastructure.StateMachine.States.StateInfrastructure;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.StateMachine
{
  public interface IGameStateMachine 
  {
    UniTask Enter<TState>() where TState : class, IState;
    UniTask Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadState<TPayload>;
  }
}