using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    protected BattleSystem BattleSystem;
    public virtual string Name { get { return "default"; } }
    public State(BattleSystem battleSystem)
    {
        BattleSystem = battleSystem;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }
    public virtual IEnumerator Attack()
    {
        yield break;
    }
    public virtual IEnumerator Heal()
    {
        yield break;
    }

}
