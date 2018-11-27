using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPatrol : MonsterState {

    [SerializeField]
    private Vector3 destination;


    public override void BeginState()
    {
        base.BeginState();
        //if (null != _manager)
        //    _manager.Animatoion.CrossFade("SL_Walk");
        destination = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        destination.y = 0;
    }

    public override void EndState()
    {
    }

    private void Update()
    {
        destination.y = 0;

        GameLib.Log(this, "Slime Dest" + destination);
        //GameLib.Log(this, "MonsterPATROL");

        if (GameLib.DetectCharacter(_manager.sight, _manager.playercc))
        {
            _manager.SetState(MonsterStates.Chase);
            return;
        }

        if ((Vector3.Distance(destination, transform.position) < 0.5f))
        {
            _manager.SetState(MonsterStates.IDLE);
            destination = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));

            return;
        }
        
        _manager.CC.CKMove(destination, _manager.MonsterState);
    }
}
