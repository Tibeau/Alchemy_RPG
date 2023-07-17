using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public override void EnterState(PlayerStateMachine player) { 
        Debug.Log("i am now idle");
    }
    public override void UpdateState(PlayerStateMachine player) { 
        
    }
}
