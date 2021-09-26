using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu (menuName = "ScriptableObjects/DataSO")]
public class DataSO : ScriptableObject
{
   
    public event UnityAction<GameObject> listChanged;

    public void ObjectChange(GameObject obj) {

        if (listChanged != null) {
            listChanged(obj);
        }
    }
}
