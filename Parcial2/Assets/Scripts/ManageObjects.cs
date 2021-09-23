using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageObjects : MonoBehaviour

{
    public DataSO channel;
    public List<GameObject> objects = new List<GameObject>();

        
    void AddObject(GameObject obj)
    {
        objects.Add(obj);
    }

    void RemoveObject(GameObject obj)
    {
        objects.Remove(obj);
    }
    
    public void ObjectUpdate(GameObject obj) //Al presionar el boton...
    {
        if (objects.Contains(obj)) RemoveObject(obj); //Si el objeto esta en la lista, borrelo.
        else AddObject(obj); //Si no, agreguelo
    }

    private void OnEnable()
    {
        channel.listChanged += ObjectUpdate;
    }

    private void OnDisanable()
    {
        channel.listChanged -= ObjectUpdate;
    }

}
