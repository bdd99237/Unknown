using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
    
    public GameObject[] targetObject;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Action();
            Action(other);
        }
    }

    public virtual void Action()
    {

    }

    public virtual void Action(Collider other)
    {

    }
}
