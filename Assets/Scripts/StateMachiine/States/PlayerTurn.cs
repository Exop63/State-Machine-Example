using System.Collections;
using System.Xml.Linq;
using UnityEngine;

public class PlayerTurn : State
{
    public override string Name => "PlayerTurn";

    public PlayerTurn(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {
        const string name = "Chose an action uparrow <color=green> Heal </color> downarrow <color=red> Attack </color>";
        Debug.Log(name);
        yield break;
    }

    public override IEnumerator Attack()
    {
        Debug.Log("Kahrol düşman al sana bombe");
        BattleSystem.enemyHealth -= BattleSystem.enemyHealth * Random.Range(0, 1.0f);

        if (BattleSystem.GameEnd)
        {
            BattleSystem.SetState(new GameEnd(BattleSystem));
        }
        else
        {
            BattleSystem.SetState(new EnemyTurn(BattleSystem));
        }
        return base.Attack();
    }
}