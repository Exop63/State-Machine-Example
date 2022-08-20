using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : StateMachine
{
    public bool GameEnd
    {
        get
        {
            return health < 1 || enemyHealth < 1;
        }
    }

    public string enemy = "Düşman";
    public float health = 100;
    public float enemyHealth = 100;
    private int turn = 1;
    public void BeginBattle()
    {

        SetState(new Begin(this));
    }
    public void Attack()
    {
        StartCoroutine(state.Attack());
    }



    public void Heal()
    {
        StartCoroutine(state.Heal());
    }


    public override void SetState(State state)
    {
        string stateMsg = $"Turn: {turn} State: {state.Name} PlayerHealth: <color=green> {health} </color> EnemyHealth: <color=red> {enemyHealth} </color>";
        Debug.Log(stateMsg);
        turn++;
        base.SetState(state);
    }

 

    private void Start()
    {
        Invoke("BeginBattle", 1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // attack
            Attack();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // heal
            Heal();
        }
    }


}
