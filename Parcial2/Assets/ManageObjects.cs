using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageObjects : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    //Lista para guardar los objetos

    public void CheckObjects(GameObject obj) //Al presionar el boton...
    {
        if (objects.Contains(obj)) RemoveObject(obj); //Si el objeo esa en la lista, borrelo.
        else AddObject(obj); //Si no, agreguelo
    }
    void AddObject(GameObject obj)
    {
        objects.Add(obj);
    }

    void RemoveObject(GameObject obj)
    {
        objects.Remove(obj);
    }

    public List<GameObject> AccesList()
    {
        return objects;
    }  

}
