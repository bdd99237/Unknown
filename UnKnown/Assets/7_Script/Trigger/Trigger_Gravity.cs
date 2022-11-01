using UnityEngine;
using System.Collections;

public class Trigger_Gravity : Trigger {

    public override void Action()
    {
        foreach(GameObject obj in targetObject)
        {
            obj.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
//Object_Fall를 대신할 스크립트