using System.Collections;
using UnityEngine;

public class EnemyTurn : State
{
    public override string Name => "EnemyTurn";

    public EnemyTurn(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        BattleSystem.Attack();
    }
    public override IEnumerator Attack()
    {
        Debug.Log("Seni dövecem oğlum ben Enemyyyyyyy!");
        BattleSystem.health -= BattleSystem.health * Random.Range(0, 1.0f);

        if (BattleSystem.GameEnd)
        {
            BattleSystem.SetState(new GameEnd(BattleSystem));
        }
        else
        {
            BattleSystem.SetState(new PlayerTurn(BattleSystem));
        }
        return base.Attack();
    }
}