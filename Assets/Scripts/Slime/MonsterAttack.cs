using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttack : MonsterState {

    public override void BeginState(){
        base.BeginState();
        //if (_manager.Target.GetComponent<FSMManager>().CurrntState == PlayerState.Dead)
        //{
        //    _manager.SetState(MonsterStates.IDLE);
        //}
    }

    public override void EndState(){
        base.EndState();
    }

    private void Update(){
        GameLib.Log(this, "MonsterAttack");
        if ((Vector3.Distance(_manager.playerTran.position, transform.position) >= _manager.MonsterState.AttackRange))
        {
            _manager.SetState(MonsterStates.Chase);
            return;
        }
        transform.LookAt(_manager.playerTran);
    }

    public void AttackCheck()
    {
        //if (_manager.CurrntState != MonsterStates.Attack) return;
        //GameLib.Log(this, "call Attack Check");

        //// 타겟에 대한 스테이트를 가져온다.
        //CharacterState targetState = _fsmmanager.target.GetComponent<CharacterState>();
        //MonsterSetting.ProcessDamage(_manager.MonsterState, targetState);
        CharacterState targetStat =
            _manager.Target.GetComponent<CharacterState>();

        MonsterSetting.ProcessDamage(_manager.MonsterState, targetStat);

    }

   
}
