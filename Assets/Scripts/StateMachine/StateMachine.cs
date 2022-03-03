using System;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private BaseState currentState;

    private void Start()
    {
        ChangeState(new IdleState());
    }

    private void Update()
    {
        if(currentState != null)
        {
            currentState.UpdateState();
        }
    }

    public void ChangeState(BaseState newState)
    {
        
        Debug.Log("Changing State");
        
        if(currentState != null)
        {
            currentState.DestroyState();
        }

        currentState = newState;

        if(currentState != null)
        {
            currentState.user = this;
            currentState.SetupState();
        }
    }
}
