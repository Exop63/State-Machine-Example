using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    protected State state;

    public virtual void SetState(State state)
    {
        this.state = state;
        StartCoroutine(state.Start());
    }
}

