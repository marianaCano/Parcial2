using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_quieto : Interfaces
{
    public Animator animator { get; set; }
    public void Execute(State states)
    {
        animator.SetBool("IsFloating", false);
    }
}
