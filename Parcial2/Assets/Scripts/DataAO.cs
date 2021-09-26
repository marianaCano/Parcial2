using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(menuName = "ScriptableObjects/DataAO")]
public class DataAO : ScriptableObject
{
    public event UnityAction objectChanged;

    public void objectChange()
    {
        objectChanged();
    }
}
