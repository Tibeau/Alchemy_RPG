using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkingState : PlayerState
{
    public override void EnterState(PlayerStateMachine player) { 
        Debug.Log("i am now walking");
    
    }
    public override void UpdateState(PlayerStateMachine player) { }
}
