

using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.StateMachine.States.StateInfrastructure
{
  public class SimpleState : IState
  {
    public virtual void Enter()
    {
    }

    public virtual UniTask Exit()
    {
      return UniTask.CompletedTask;
    }

    void IExitableState.EndExit(){}
  }
}