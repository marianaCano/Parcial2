using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Interfaces
{
    public Animator animator {get; set;}
    void Execute(State states); 
}
