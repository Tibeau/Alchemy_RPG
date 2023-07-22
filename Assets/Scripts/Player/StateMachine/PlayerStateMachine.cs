using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{

    public PlayerState currentState;
    public PlayerIdleState IdleState = new PlayerIdleState();
    public PlayerWalkingState WalkingState = new PlayerWalkingState();

    // Start is called before the first frame update
    void Start()
    {
        currentState = IdleState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);

        bool hasMovementInput = GetComponent<PlayerMovement>().HasMovementInput();

        if (hasMovementInput)
        {
            SwitchState(WalkingState);
        }
        else
        {
            SwitchState(IdleState);
        }
    }

   public void SwitchState(PlayerState state) {
        currentState = state;
        state .EnterState(this);
    }
}
