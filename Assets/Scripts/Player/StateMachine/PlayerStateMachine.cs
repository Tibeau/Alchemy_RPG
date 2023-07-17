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

          // Check if the player has movement input
        bool hasMovementInput = GetComponent<PlayerMovement>().HasMovementInput();

        if (hasMovementInput)
        {
            // Switch to the walking state if the player is moving
            SwitchState(WalkingState);
        }
        else
        {
            // Switch back to the idle state if the player is not moving
            SwitchState(IdleState);
        }
    }

   public void SwitchState(PlayerState state) {
        currentState = state;
        state .EnterState(this);
    }
}
