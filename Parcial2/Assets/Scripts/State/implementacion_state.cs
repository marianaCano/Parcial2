using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class implementacion_state : MonoBehaviour
{
    public ManageObjects manageobject;
    public State states;
    public DataSO channel;
    private void OnEnable()
    {
        channel.listChanged += StateUpdate;
        Debug.Log("MALPARIDA COSA4");
    }
    private void OnDisanable()
    {
        channel.listChanged -= StateUpdate;
        Debug.Log("MALPARIDA COSA5");
    }
    public void StateUpdate(GameObject obj)
    {
        if (manageobject.objects.Contains(obj))
        {
            Debug.Log("MALPARIDA COSA6");
            states.Quieto();
        }
        else
        {
            states.Rotar();
            Debug.Log("MALPARIDA COSA7");
        }
    }
    
   
}
