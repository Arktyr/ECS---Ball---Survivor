namespace Code.Infrastructure.StateMachine.States.StateInfrastructure
{
  public interface IState: IExitableState
  {
    void Enter();
  }
}