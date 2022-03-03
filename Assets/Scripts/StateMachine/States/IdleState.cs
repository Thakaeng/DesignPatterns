using UnityEngine;

public class IdleState : BaseState
{
    public float minIdleTime = 2f;
    public float maxIdleTime = 4f;

    private float timeToIdle;

    public override void SetupState()
    {
        base.SetupState();

        timeToIdle = Random.Range(minIdleTime, maxIdleTime);
        
        Debug.Log("Idle time: " + timeToIdle);
    }
    
    public override void UpdateState()
    {
        base.UpdateState();

        timeToIdle -= Time.deltaTime;

        if(timeToIdle < 0)
        {
            user.ChangeState(new MoveState());
        }
    }
}
