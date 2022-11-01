using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interaction : MonoBehaviour {
    
    public void Active_Effect()
    {
        List<Renderer> renderer = new List<Renderer>();
        renderer.AddRange(GetComponentsInChildren<Renderer>());
        foreach(Renderer objRenderer in renderer)
        {
            objRenderer.material.color = Color.red;
        }
    }

    public void DeActive_Effect()
    {
        List<Renderer> renderer = new List<Renderer>();
        renderer.AddRange(GetComponentsInChildren<Renderer>());
        foreach (Renderer objRenderer in renderer)
        {
            objRenderer.material.color = Color.white;
        }
    }

    public virtual void Action()
    {

    }

    public virtual void Sound()
    {
        if(GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}

//TriggerButton를 대체하는 스크립트