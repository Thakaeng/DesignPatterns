public abstract class BaseState
{
    public StateMachine user;

    public virtual void SetupState(){}
    public virtual void UpdateState(){}
    public virtual void DestroyState(){}
}
