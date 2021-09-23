using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal interface IChangeObject
{
    public ManageObjects MO { get; set; }
    void HandleObject();
    void CheckObjects();
}
