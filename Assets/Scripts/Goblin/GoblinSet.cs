using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinSet : CharacterState{
    // Monster State
    //private StateDataManager StateData;

    protected override void Awake()
    {
        base.Awake();
        _hp = stateData.maxHP;
        _AttackRange = stateData.MaxRange;
        Debug.Log(stateData.maxHP);
        //GameLib.Log(this, "statePlayer.maxHP");
    }
}
