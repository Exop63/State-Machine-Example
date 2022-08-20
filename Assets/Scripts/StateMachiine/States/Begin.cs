using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Begin : State
{
    public override string Name => "Begin";
    public Begin(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {

        Debug.Log($"A wild {BattleSystem.enemy} appeared!");
        yield return new WaitForSeconds(2);
        BattleSystem.SetState(new PlayerTurn(BattleSystem));
    }
}

