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
        Debug.Log("ME VOY A MATAR");
    }
    public void Vacio()
    {
        stateInterfaces = new vacio();
        stateInterfaces.Execute(this);
        Debug.Log("ME VOY A MATAR");
    }
    public void Quieto()
    {
        stateInterfaces = new state_rotando();
        stateInterfaces.Execute(this);
        Debug.Log("ME VOY A MATAR");
    }
    public void Rotar()
    {
        stateInterfaces = new state_rotando();
        stateInterfaces.Execute(this);
        Debug.Log("ME VOY A MATAR");
    }

   

}  