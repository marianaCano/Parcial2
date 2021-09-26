using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_quieto : Interfaces
{
    public void Execute(State states)
    {
       states.transform.Rotate(new Vector3(0f, 0f, 0f) * Time.deltaTime);
        Debug.Log("MALPARIDA COSA2");
    }
}
