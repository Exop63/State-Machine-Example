using System.Collections;
using UnityEngine;

public class GameEnd : State
{
    public GameEnd(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {
        if(BattleSystem.health >1)
        {
            Debug.Log("Tebrikler kazandın!");
        }else
        {
            Debug.Log("Kaybettin!");
        }
        return base.Start();
    }
}