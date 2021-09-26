using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour , IChangeObject
{
    public ManageObjects MO { get ; set; }
    public List<Transform> transforms = new List<Transform>();
    bool sized = false;
    Vector3 tamano=new Vector3(0.3f, 0.3f, 0.3f);

    public void CheckObjects()
    {
        transforms.Clear();
        foreach (GameObject obj in MO.objects)
        {
            transforms.Add(obj.transform);
        }
    }

    public void HandleObject()
    {
        CheckObjects();
        foreach (Transform trns in transforms)
        {
            if (!sized)
                _ChangeSize(false);
            else
                _ChangeSize(true);
        }
        sized = !sized;
    }

    public void _ChangeSize(bool signo)
    {
        if (signo)
            transform.localScale = transform.localScale + tamano;
        else
            transform.localScale = transform.localScale - tamano;
    }
}
