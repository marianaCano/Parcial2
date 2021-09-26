using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class implementacion_state : MonoBehaviour
{
    public ManageObjects manageobject;
    public DataSO channel; 
    private void OnEnable()
    {
        channel.listChanged += StateUpdate;
    }
    private void OnDisanable()
    {
        channel.listChanged -= StateUpdate;
    }
    public void StateUpdate(GameObject obj)
    {
        if (manageobject.objects.Contains(obj))
        {
            obj.GetComponent<State>().Quieto();
        }
        else
        {
            obj.GetComponent<State>().Rotar();
        }
    }
    
   
}
