using UnityEngine;
using System.Collections;

public class Trigger_Destroy : Trigger_Delay
{

    public bool destroy;

    public override IEnumerator Action_Delay()
    {
        yield return new WaitForSeconds(delayTime[0]);
        foreach (GameObject obj in targetObject)
        {
            Destroy(obj);
        }
        if (destroy)
        {
            Destroy(gameObject);
        }
    }
}
//destroyOnTriggerEnter를 대신할 스크립트