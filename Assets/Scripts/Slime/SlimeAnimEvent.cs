using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAnimEvent : MonoBehaviour {

    //MonsteFSMManager _manager;

    //private void Awake()
    //{
    //    _manager = transform.root.GetComponent<MonsteFSMManager>();
    //}

    //void AttackEvent()
    //{
    //    _manager.AttackBehavior();
    //}

    //void AttackEnd()
    //{
    //    _manager.SetState(MonsterStates.IDLE);
    //}


    MonsteFSMManager _manager;
    private void Awake()
    {
        _manager = transform.root.GetComponent<MonsteFSMManager>();
    }

    void HitCheck()
    {
        GameLib.Log(this, "HitCheck");

        // 효율 쓰레기니까 사용하지 않으면 좋다.
        // transform.root.SendMessage("AttackCheck");


        MonsterAttack attackState = _manager.CurrentSateComponent as MonsterAttack;
        if (attackState != null)
        {
            attackState.AttackCheck();
        }
    }

}
