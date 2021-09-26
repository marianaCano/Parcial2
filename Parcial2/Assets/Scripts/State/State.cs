using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    private Interfaces stateInterfaces;
    void Awake()
    {
        stateInterfaces = new vacio();
        stateInterfaces.Execute(this);
    }
    public void Vacio()
    {
        stateInterfaces = new vacio();
        stateInterfaces.Execute(this);
    }
    public void Quieto()
    {
        stateInterfaces = new state_quieto();
        stateInterfaces.animator = GetComponent<Animator>();
        stateInterfaces.Execute(this);
    }
    public void Rotar()
    {
        stateInterfaces = new state_rotando();
        stateInterfaces.animator = GetComponent<Animator>();
        stateInterfaces.Execute(this);
    }

   

}  