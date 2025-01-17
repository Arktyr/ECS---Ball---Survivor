
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.StateMachine.States.StateInfrastructure
{
  public interface IExitableState
  { 
    UniTask Exit();
    void EndExit();
  }
}