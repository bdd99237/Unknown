using UnityEngine;
using System.Collections;

public class Trigger_Active : Trigger
{
    [SerializeField]
    bool active;

    public bool destroy;

    public override void Action()
    {
        foreach(GameObject obj in targetObject)
        {
            obj.SetActive(active);
        }
        if(destroy)
        {
            Destroy(gameObject);
        }
    }
}
//setActiveOnTriggerEnter를 대신할 부분