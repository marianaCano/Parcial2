using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textUIUpdater : MonoBehaviour
{
    public ManageObjects manageObjects;
    public DataSO channel;
    public Text text;

    private void OnEnable()
    {
        channel.listChanged += TextUpdate;
    }

    private void OnDisanable()
    {
        channel.listChanged -= TextUpdate;
    }

    public void TextUpdate(GameObject obj)
    {
        if (manageObjects.objects.Count == 0) text.text = "Agregar objetos";

        if (manageObjects.objects.Contains(obj))
        {
            text.text = obj.name + " " +"eliminado";
        }
        else {
            text.text = obj.name + " " + "agregado";
        }


    }
}
