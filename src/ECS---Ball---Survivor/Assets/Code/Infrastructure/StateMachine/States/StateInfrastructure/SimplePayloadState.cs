using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.StateMachine.States.StateInfrastructure
{
  public class SimplePayloadState<TPayload> : IPayloadState<TPayload>
  {
    public virtual void Enter(TPayload payload)
    {
    }

    public virtual UniTask Exit()
    {
      return UniTask.CompletedTask;;
    }

    void IExitableState.EndExit()
    {
      
    }
  }
}