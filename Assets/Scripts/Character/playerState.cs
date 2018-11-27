using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerState : CharacterState {

    

    protected override void Awake()
    {
        base.Awake();
        _hp = stateData.maxHP;
        _AttackRange = stateData.MaxRange;
        Debug.Log(stateData.maxHP);
        //GameLib.Log(this, "statePlayer.maxHP");
    }
}
