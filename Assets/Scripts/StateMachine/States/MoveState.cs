using UnityEngine;

public class MoveState : BaseState
{
    public float maxMoveDistance = 5f;
    
    private Vector3 targetRelativePosition;
    private Vector3 targetWorldPosition;

    private SimpleMovement userMovement;

    public override void SetupState()
    {
        base.SetupState();

        targetRelativePosition = new Vector3(
            Random.Range(-maxMoveDistance, maxMoveDistance),
            0f,
            Random.Range(-maxMoveDistance, maxMoveDistance));
        
        targetWorldPosition = user.transform.position + targetRelativePosition;
        
        Debug.Log("Move: " + targetRelativePosition);
        
        userMovement = user.GetComponent<SimpleMovement>();
    }

    public override void UpdateState()
    {
        base.UpdateState();
        
        
        userMovement.TargetPosition = targetRelativePosition;

        float dist = Vector3.Distance(user.transform.position, targetWorldPosition);
        
        if(dist < 1f || dist > 10f)
        {
            userMovement.TargetPosition = Vector3.zero;
            user.ChangeState(new IdleState());
        }

    }
}
