using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_rotando : Interfaces
{
    public void Execute(State states)
    {
        states.transform.Rotate(new Vector3(20f, 20f, 20f) * Time.deltaTime);
        Debug.Log("MALPARIDA COSA");
    }
}
