using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour, IChangeObject

{
    public List<AudioSource> AudSources = new List<AudioSource>();
    bool isActuallyPlaying = false;
    public ManageObjects MO { get; set ; }

    public void CheckObjects()
    {
        AudSources.Clear();
        foreach (GameObject obj in MO.objects)
        {
            AudSources.Add(obj.GetComponent<AudioSource>());
        }
    }

    public void HandleObject()
    {
        CheckObjects();
        foreach (AudioSource aSource in AudSources)
        {
            if (!isActuallyPlaying)
                aSource.Play();
            else
                aSource.Stop();
        }
        isActuallyPlaying = !isActuallyPlaying;
    }

}
